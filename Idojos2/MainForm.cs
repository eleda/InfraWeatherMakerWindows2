using System;
using System.Drawing;
using System.Windows.Forms;

namespace Idojos2
{
    public partial class MainForm : Form
    {
        private Bitmap tabla1 = new Bitmap(1280, 720);
        private Bitmap tabla2 = new Bitmap(1280, 720);
        int knum = 0;
        string background = "";
        string saveFolder = "";
        string browserUrl = "about:blank";
        Time[] ij = new Time[10];

        public struct Time
        {
            public string days;
            public int minimum, maximum, wea;

            public Time(string days, int minimum, int maximum, int wea)
            {
                this.days = days;
                this.minimum = minimum;
                this.maximum = maximum;
                this.wea = wea;
            }
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Infra WeatherMaker V" + Application.ProductVersion.ToString();
            DateTime ct = DateTime.Now;
            System.DateTime answer;

            for (int i = 0; i < 10; i++)
            {
                answer = ct.AddDays(i);
                ij[i].days = answer.ToString("d");
            }
            
            DateGridView.RowCount = 10;
            LoadFromRegistry(ref ij);
            FillTable(ref ij);
        }

        public void FillTable(ref Time[] vc)
        {
            for (int i = 0; i < 10; i++)
            {
                DateGridView.Rows[i].Cells[0].Value = vc[i].days;
                DateGridView.Rows[i].Cells[1].Value = vc[i].minimum;
                DateGridView.Rows[i].Cells[2].Value = vc[i].maximum;
                switch (vc[i].wea)
                {
                    case 1: DateGridView.Rows[i].Cells[3].Value = InfraWeatherMaker.Properties.Resources.weath1; break;
                    case 2: DateGridView.Rows[i].Cells[3].Value = InfraWeatherMaker.Properties.Resources.weath2; break;
                    case 3: DateGridView.Rows[i].Cells[3].Value = InfraWeatherMaker.Properties.Resources.weath3; break;
                    case 4: DateGridView.Rows[i].Cells[3].Value = InfraWeatherMaker.Properties.Resources.weath4; break;
                    case 5: DateGridView.Rows[i].Cells[3].Value = InfraWeatherMaker.Properties.Resources.weath5; break;
                    case 6: DateGridView.Rows[i].Cells[3].Value = InfraWeatherMaker.Properties.Resources.weath6; break;
                    case 7: DateGridView.Rows[i].Cells[3].Value = InfraWeatherMaker.Properties.Resources.weath7; break;
                    case 8: DateGridView.Rows[i].Cells[3].Value = InfraWeatherMaker.Properties.Resources.weath8; break;
                    case 9: DateGridView.Rows[i].Cells[3].Value = InfraWeatherMaker.Properties.Resources.weath9; break;
                    case 10: DateGridView.Rows[i].Cells[3].Value = InfraWeatherMaker.Properties.Resources.weath10; break;
                    case 11: DateGridView.Rows[i].Cells[3].Value = InfraWeatherMaker.Properties.Resources.weath1; break;
                }
            }
            BackgroundTextBox.Text = background;
            SaveFolderTextBox.Text = saveFolder;
            AddressToolStripTextBox.Text = browserUrl;
        }

        public void FromTable(ref Time[] vc)
        {
            for (int i = 0; i < 10; i++)
            {
                vc[i].minimum = Int16.Parse(DateGridView.Rows[i].Cells[1].FormattedValue.ToString());
                vc[i].maximum = Int16.Parse(DateGridView.Rows[i].Cells[2].FormattedValue.ToString());
            }
        }

        public void SaveToRegistry(ref Time[] vc)
        {
            Microsoft.Win32.RegistryKey key, keydate, keymax, keymin, keyoptions, keypicture, keytype;
            key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("Infra").CreateSubKey("WeatherMaker");
            keydate = key.CreateSubKey("Date");
            keymax = key.CreateSubKey("Max");
            keymin = key.CreateSubKey("Min");
            keyoptions = key.CreateSubKey("Options");
            keypicture = key.CreateSubKey("Picture");
            keytype = key.CreateSubKey("Type");

            for (int i = 0; i < 10; i++)
            {
                keymin.SetValue("d" + i, vc[i].minimum);
                keymax.SetValue("d" + i, vc[i].maximum);
                keypicture.SetValue("d" + i, vc[i].wea);
                keydate.SetValue("d" + i, vc[i].days);
            }

            keyoptions.SetValue("ImageFile", background);
            keyoptions.SetValue("SavingFolder", saveFolder);
            keyoptions.SetValue("BrowserURL", browserUrl);

            key.Close();
        }

        public void LoadFromRegistry(ref Time[] vc)
        {
            Microsoft.Win32.RegistryKey key, keydate, keymax, keymin, keyoptions, keypicture, keytype;
            try
            {
                key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("Infra").OpenSubKey("WeatherMaker");
                keyoptions = key.OpenSubKey("Options");
                keytype = key.OpenSubKey("Type");

                for (int i = 0; i < 10; i++)
                {
                    keymin = key.OpenSubKey("Min");
                    vc[i].minimum = Int16.Parse(keymin.GetValue("d" + i).ToString());
                    keymin.Close();

                    keymax = key.OpenSubKey("Max");
                    vc[i].maximum = Int16.Parse(keymax.GetValue("d" + i).ToString());
                    keymax.Close();

                    keypicture = key.OpenSubKey("Picture");
                    vc[i].wea = Int16.Parse(keypicture.GetValue("d" + i).ToString());
                    keypicture.Close();
                }

                background = keyoptions.GetValue("ImageFile", "").ToString();
                saveFolder = keyoptions.GetValue("SavingFolder", "").ToString();
                browserUrl = keyoptions.GetValue("BrowserURL", "").ToString();

                key.Close();
            }
            catch
            {
                MessageBox.Show("Ön valószínűleg először használja az Időjárás jelentő programot. Ez alkalomból a program létrehozta önnek a Registry beállításokat.", "Infó", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SaveToRegistry(ref ij);
            }
        }

        private void AutoSizeControl(Control control, int textPadding)
        {
            // Create a Graphics object for the Control.
            Graphics g = control.CreateGraphics();

            // Get the Size needed to accommodate the formatted Text.
            Size preferredSize = g.MeasureString(
               control.Text, control.Font).ToSize();

            // Pad the text and resize the control.
            control.ClientSize = new Size(
               preferredSize.Width + (textPadding * 2),
               preferredSize.Height + (textPadding * 2));

            // Clean up the Graphics object.
            g.Dispose();
        }

        public void DrawLinePoint(PaintEventArgs e)
        {
            // Create pen.
            Pen blackPen = new Pen(Color.Black, 3);

            // Create points that define line.
            Point point1 = new Point(100, 100);
            Point point2 = new Point(500, 100);

            // Draw line to screen.
            e.Graphics.DrawLine(blackPen, point1, point2);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveToRegistry(ref ij);
        }

        private void idk_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            FromTable(ref ij);
            FillTable(ref ij);
        }

        private void Picture1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen toll = new Pen(Color.DarkBlue);
            g.DrawRectangle(toll, 30, 30, 20, 20);
        }

        public void DrawTables(ref Time[] vc)
        {
            Graphics t1 = Graphics.FromImage(tabla1);
            Graphics t2 = Graphics.FromImage(tabla2);

            t1.Clear(Color.Transparent);
            t2.Clear(Color.Transparent);

            if (background != "")
            {
                t1.DrawImage(Image.FromFile(background), 0, 0, 1280, 720);
                t2.DrawImage(Image.FromFile(background), 0, 0, 1280, 720);
            }

            Font b_cim = new Font("Candara", 32);
            Brush fekete = Brushes.Black;
            Brush feher = Brushes.NavajoWhite;
            Brush kfeher = Brushes.Gray;
            Brush sotet = Brushes.DarkBlue;
            Brush ksotet = Brushes.LightSteelBlue;
            Brush vilagos = Brushes.AliceBlue;

            string tnap = "A következő tíz nap időjárása";
            t1.DrawString(tnap, b_cim, fekete, 52, 52);
            t2.DrawString(tnap, b_cim, fekete, 52, 52);

            t1.DrawString(tnap, b_cim, feher, 50, 50);
            t2.DrawString(tnap, b_cim, feher, 50, 50);

            Font os = new Font("Candara", 26);
            int px = 0;

            for (int bb = 0; bb < 5; bb++)
            {
                t1.DrawImage(InfraWeatherMaker.Properties.Resources.wmbox, 50 + px, 150, 200, 540);
                t2.DrawImage(InfraWeatherMaker.Properties.Resources.wmbox, 50 + px, 150, 200, 540);

                Font p20 = new Font("Candara", 20);
                Font pmm = new Font("Candara", 18, FontStyle.Italic);
                Font p30 = new Font("Candara", 35, FontStyle.Bold);
                Font pnn = new Font("Candara", 45);
                Font pnnk = new Font("Candara", 45);

                string dat = vc[bb].days;
                string dat2 = vc[bb + 5].days;

                t1.DrawString(Mon(dat), p20, fekete, 90 + px, 190);
                t2.DrawString(Mon(dat2), p20, fekete, 90 + px, 190);

                t1.DrawString(Day(dat), pnn, kfeher, 139 + px, 164);
                t2.DrawString(Day(dat2), pnn, kfeher, 139 + px, 164);

                t1.DrawString(Day(dat), pnn, feher, 140 + px, 165);
                t2.DrawString(Day(dat2), pnn, feher, 140 + px, 165);

                t1.DrawImage(WeatherIcon(vc[bb].wea), 100 + px, 245, 110, 110);
                t2.DrawImage(WeatherIcon(vc[bb + 5].wea), 100 + px, 245, 110, 110);

                t1.DrawString("max.", pmm, sotet, 125 + px, 425);
                t2.DrawString("max.", pmm, sotet, 125 + px, 425);

                t1.DrawString(vc[bb].maximum.ToString() + "°C", p30, sotet, 108 + px, 453);
                t2.DrawString(vc[bb + 5].maximum.ToString() + "°C", p30, sotet, 108 + px, 453);
                t1.DrawString(vc[bb].maximum.ToString() + "°C", p30, vilagos, 105 + px, 450);
                t2.DrawString(vc[bb + 5].maximum.ToString() + "°C", p30, vilagos, 105 + px, 450);

                t1.DrawString("min.", pmm, fekete, 125 + px, 525);
                t2.DrawString("min.", pmm, fekete, 125 + px, 525);

                t1.DrawString(vc[bb].minimum.ToString() + "°C", p30, fekete, 108 + px, 553);
                t2.DrawString(vc[bb + 5].minimum.ToString() + "°C", p30, fekete, 108 + px, 553);

                t1.DrawString(vc[bb].minimum.ToString() + "°C", p30, ksotet, 105 + px, 550);
                t2.DrawString(vc[bb + 5].minimum.ToString() + "°C", p30, ksotet, 105 + px, 550);

                px += 240;
            }
        }

        public string Day(string d)
        {
            return Int16.Parse(d.Substring(8, 2)).ToString() + ".";
        }

        public string Mon(string d)
        {
            string ho = "";
            switch (Int16.Parse(d.Substring(5, 2)))
            {
                case 1: ho = "jan."; break;
                case 2: ho = "feb."; break;
                case 3: ho = "márc."; break;
                case 4: ho = "ápr."; break;
                case 5: ho = "máj."; break;
                case 6: ho = "jún."; break;
                case 7: ho = "júl."; break;
                case 8: ho = "aug."; break;
                case 9: ho = "szept."; break;
                case 10: ho = "okt."; break;
                case 11: ho = "nov."; break;
                case 12: ho = "dec."; break;
            }
            return ho;
        }

        public Bitmap WeatherIcon(int ido)
        {
            switch (ido)
            {
                case 1: return InfraWeatherMaker.Properties.Resources.weath1;
                case 2: return InfraWeatherMaker.Properties.Resources.weath2;
                case 3: return InfraWeatherMaker.Properties.Resources.weath3;
                case 4: return InfraWeatherMaker.Properties.Resources.weath4;
                case 5: return InfraWeatherMaker.Properties.Resources.weath5;
                case 6: return InfraWeatherMaker.Properties.Resources.weath6;
                case 7: return InfraWeatherMaker.Properties.Resources.weath7;
                case 8: return InfraWeatherMaker.Properties.Resources.weath8;
                case 9: return InfraWeatherMaker.Properties.Resources.weath9;
                case 10: return InfraWeatherMaker.Properties.Resources.weath10;
                case 11: return InfraWeatherMaker.Properties.Resources.weath11;
            }
            return InfraWeatherMaker.Properties.Resources.whatisthis;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            knum = 1;
            PreviewPictureBox.Image = tabla2;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            knum = 0;
            PreviewPictureBox.Image = tabla1;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            SplitContainer.Panel2Collapsed = false;
            BrowserToolStripButton.Checked = true;
        }

        private void idk_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                DialogResult dr = new DialogResult();
                Properties.ChooseWeatherImageDialog idoablak = new Properties.ChooseWeatherImageDialog();
                dr = idoablak.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    switch (idoablak.aktido())
                    {
                        case "weath1": ij[e.RowIndex].wea = 1; break;
                        case "weath2": ij[e.RowIndex].wea = 2; break;
                        case "weath3": ij[e.RowIndex].wea = 3; break;
                        case "weath4": ij[e.RowIndex].wea = 4; break;
                        case "weath5": ij[e.RowIndex].wea = 5; break;
                        case "weath6": ij[e.RowIndex].wea = 6; break;
                        case "weath7": ij[e.RowIndex].wea = 7; break;
                        case "weath8": ij[e.RowIndex].wea = 8; break;
                        case "weath9": ij[e.RowIndex].wea = 9; break;
                        case "weath10": ij[e.RowIndex].wea = 10; break;
                        case "weath11": ij[e.RowIndex].wea = 11; break;
                    }
                    FillTable(ref ij);
                }
            }
        }


        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            DrawTables(ref ij);
        }

        private void fdr_TextChanged(object sender, EventArgs e)
        {
            saveFolder = SaveFolderTextBox.Text.ToString();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            DialogResult o = new DialogResult();
            o = OpenFileDialog.ShowDialog();
            if (o == DialogResult.OK)
            {
                BackgroundTextBox.Text = OpenFileDialog.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult o = new DialogResult();
            o = FolderBrowserDialog.ShowDialog();
            if (o == DialogResult.OK)
            {
                SaveFolderTextBox.Text = FolderBrowserDialog.SelectedPath;
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            SaveToFile();
        }

        public void SaveToFile()
        {
            tabla1.Save(saveFolder + "\\" + "w1.png", System.Drawing.Imaging.ImageFormat.Png);
            tabla2.Save(saveFolder + "\\" + "w2.png", System.Drawing.Imaging.ImageFormat.Png);
            MessageBox.Show("Sikerült!");
        }

        private void hk_TextChanged_1(object sender, EventArgs e)
        {
            background = BackgroundTextBox.Text;
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            AboutDialog a = new AboutDialog();
            a.ShowDialog();
        }

        public void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            WebBrowser.Navigate(AddressToolStripTextBox.Text);
        }

        private void laun_Click(object sender, EventArgs e)
        {
            browserUrl = AddressToolStripTextBox.Text.ToString();
        }

        private void wb1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            AddressToolStripTextBox.Text = WebBrowser.Url.OriginalString;
        }
    }
}
