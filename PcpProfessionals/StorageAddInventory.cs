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
    public partial class StorageAddInventory : Form
    {
        public StorageAddInventory()
        {
            InitializeComponent();
        }

        private void storageBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.storageBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pcpProfessionalDataSet);

        }

        private void StorageAddInventory_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            // TODO: This line of code loads data into the 'pcpProfessionalDataSet.Storage' table. You can move, or remove it, as needed.
            this.storageTableAdapter.Fill(this.pcpProfessionalDataSet.Storage);

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            var addInventory = new AddInventory();

            FormManager.GotoForm(this, addInventory);
        }
    }
}
