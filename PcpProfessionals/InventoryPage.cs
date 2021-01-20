using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities;

namespace PcpProfessionals
{
    public partial class InventoryPage : Form
    {
        public InventoryPage()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.BiBtn.Enabled = false;
            this.AnalyseInvBtn.Enabled = false;
            this.RptGenBtn.Enabled = false;
            this.CompManagerBtn.Enabled = false;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var searchInventory = new SearchInventory();

            FormManager.GotoForm(this, searchInventory);
        }

        private void AddInvBtn_Click(object sender, EventArgs e)
        {
            var addInv = new AddInventory();

            FormManager.GotoForm(this, addInv);
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            var homePage = new HomePage();

            FormManager.GotoForm(this, homePage);
        }
    }
}
