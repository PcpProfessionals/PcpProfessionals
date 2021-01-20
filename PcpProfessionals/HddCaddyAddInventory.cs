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
    public partial class HddCaddyAddInventory : Form
    {
        private string _componentLabelText;

        public HddCaddyAddInventory()
        {

        }

        public HddCaddyAddInventory(string componentLabelName)
        {
            InitializeComponent();
            _componentLabelText = componentLabelName;
        }

        private void hddCadyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hddCadyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pcpProfessionalDataSet);

        }

        private void HddCaddyAddInventory_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            // TODO: This line of code loads data into the 'pcpProfessionalDataSet.HddCady' table. You can move, or remove it, as needed.
            this.hddCadyTableAdapter.Fill(this.pcpProfessionalDataSet.HddCady);
            this.ComponentNameLbl.Text = _componentLabelText;

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            var addInventory = new AddInventory();

            FormManager.GotoForm(this, addInventory);
        }
    }
}
