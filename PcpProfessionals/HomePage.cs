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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void InventoryModuleBtn_Click(object sender, EventArgs e)
        {
            var inventoryHome = new InventoryPage();

            inventoryHome.ShowDialog();

            this.Hide();
        }
    }
}
