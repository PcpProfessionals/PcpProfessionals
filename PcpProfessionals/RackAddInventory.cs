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
    public partial class RackAddInventory : Form
    {
        private string _componentLabelText;

        public RackAddInventory(string componentLabelName)
        {
            InitializeComponent();
            _componentLabelText = componentLabelName;
        }

        private void rackBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rackBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pcpProfessionalDataSet);

        }

        private void RackAddInventory_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            // TODO: This line of code loads data into the 'pcpProfessionalDataSet.Rack' table. You can move, or remove it, as needed.
            this.rackTableAdapter.Fill(this.pcpProfessionalDataSet.Rack);
            this.ComponentNameLbl.Text = _componentLabelText;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            var addInventory = new AddInventory();

            FormManager.GotoForm(this, addInventory);
        }
    }
}
