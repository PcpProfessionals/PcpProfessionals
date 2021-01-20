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
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void InventoryModuleBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            var inventoryHome = new InventoryPage();

            inventoryHome.ShowDialog();

            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            this.SalesModuleBtn.Enabled = false;
            this.PurchaseModuleBtn.Enabled = false;
            this.ReportModuleBtn.Enabled = false;
        }
    }
}
