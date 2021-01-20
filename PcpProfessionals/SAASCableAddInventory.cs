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
    public partial class SAASCableAddInventory : Form
    {
        public SAASCableAddInventory()
        {
            InitializeComponent();
        }

        private void sAASCableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sAASCableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pcpProfessionalDataSet);

        }

        private void SAASCableAddInventory_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            // TODO: This line of code loads data into the 'pcpProfessionalDataSet.SAASCable' table. You can move, or remove it, as needed.
            this.sAASCableTableAdapter.Fill(this.pcpProfessionalDataSet.SAASCable);

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            var addInventory = new AddInventory();

            FormManager.GotoForm(this, addInventory);
        }
    }
}
