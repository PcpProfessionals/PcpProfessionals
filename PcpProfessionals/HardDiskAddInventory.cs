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
    public partial class HardDiskAddInventory : Form
    {
        private string _compoentLabelText;

        public HardDiskAddInventory()
        {

        }

        public HardDiskAddInventory(string componentLabelName)
        {
            InitializeComponent();
            _compoentLabelText = componentLabelName;
        }

        private void harddiskBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.harddiskBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pcpProfessionalDataSet);
        }

        private void HardDiskAddInventory_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            // TODO: This line of code loads data into the 'pcpProfessionalDataSet.Harddisk' table. You can move, or remove it, as needed.
            this.harddiskTableAdapter.Fill(this.pcpProfessionalDataSet.Harddisk);
            this.ComponentNameLbl.Text = _compoentLabelText;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            var addInventory = new AddInventory();

            FormManager.GotoForm(this, addInventory);
        }
    }
}
