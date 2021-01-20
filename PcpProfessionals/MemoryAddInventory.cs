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
    public partial class MemoryAddInventory : Form
    {
        private string _componentNameText;

        public MemoryAddInventory()
        {

        }

        public MemoryAddInventory(string componentNameLabel)
        {
            InitializeComponent();
            _componentNameText = componentNameLabel;
        }

        private void memoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.memoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pcpProfessionalDataSet);

        }

        private void MemoryAddInventory_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            // TODO: This line of code loads data into the 'pcpProfessionalDataSet.Memory' table. You can move, or remove it, as needed.
            this.memoryTableAdapter.Fill(this.pcpProfessionalDataSet.Memory);
            this.ComponentNameLbl.Text = _componentNameText;
        }

        private void rankTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            var addInventory = new AddInventory();

            FormManager.GotoForm(this, addInventory);
        }
    }
}
