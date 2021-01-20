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
    public partial class LedAddInventory : Form
    {
        private string _componentLabelText;

        public LedAddInventory()
        {

        }

        public LedAddInventory(string componentNameLabel)
        {
            InitializeComponent();
            _componentLabelText = componentNameLabel;
        }

        private void lEDBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lEDBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pcpProfessionalDataSet);

        }

        private void LedAddInventory_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            // TODO: This line of code loads data into the 'pcpProfessionalDataSet.LED' table. You can move, or remove it, as needed.
            this.lEDTableAdapter.Fill(this.pcpProfessionalDataSet.LED);
            this.ComponentNameLbl.Text = _componentLabelText;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            var addInventory = new AddInventory();

            FormManager.GotoForm(this, addInventory);
        }
    }
}
