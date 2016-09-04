using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;



namespace Idojos2.Properties
{
    public partial class ChooseWeatherImageDialog : Form
    {

        string aid = "";

        public ChooseWeatherImageDialog()
        {
            InitializeComponent();
        }

        private void idojs_Load(object sender, EventArgs e)
        {
            listView1.Items.Add("weath1", "Időjárás 1", "weath1");
            listView1.Items.Add("weath2", "Időjárás 2", "weath2");
            listView1.Items.Add("weath3", "Időjárás 3", "weath3");
            listView1.Items.Add("weath4", "Időjárás 4", "weath4");
            listView1.Items.Add("weath5", "Időjárás 5", "weath5");
            listView1.Items.Add("weath6", "Időjárás 6", "weath6");
            listView1.Items.Add("weath7", "Időjárás 7", "weath7");
            listView1.Items.Add("weath8", "Időjárás 8", "weath8");
            listView1.Items.Add("weath9", "Időjárás 9", "weath9");
            listView1.Items.Add("weath10", "Időjárás 10", "weath10");
            listView1.Items.Add("weath11", "Időjárás 11", "weath11");

        }

        public string aktido()
         {
            return aid;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                aid = listView1.SelectedItems[0].Name.ToString();
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
