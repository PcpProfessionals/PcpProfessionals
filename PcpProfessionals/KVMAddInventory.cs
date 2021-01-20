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
    public partial class KVMAddInventory : Form
    {
        public KVMAddInventory()
        {
            InitializeComponent();
        }

        private void kVMBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kVMBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pcpProfessionalDataSet);

        }

        private void KVMAddInventory_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            // TODO: This line of code loads data into the 'pcpProfessionalDataSet.KVM' table. You can move, or remove it, as needed.
            this.kVMTableAdapter.Fill(this.pcpProfessionalDataSet.KVM);
        }

        private void Back_Click(object sender, EventArgs e)
        {
            var addInventory = new AddInventory();

            FormManager.GotoForm(this, addInventory);
        }
    }
}
