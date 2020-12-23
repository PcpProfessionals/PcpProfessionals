using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PcpProfessionals
{
    public partial class SearchInventory : Form
    {
        public SearchInventory()
        {
            InitializeComponent();

            LoadDefaultValues();
            
        }

        private void LoadDefaultValues()
        {
            var seedList = new List<string>() 
            {
                "HardDisk","RAM","Processor"
            };

            ComponentListCb.DataSource = seedList;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
