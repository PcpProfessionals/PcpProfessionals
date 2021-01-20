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
    public partial class PowerSupplyAddInventory : Form
    {
        private string _componentLabelText;

        public PowerSupplyAddInventory()
        {

        }

        public PowerSupplyAddInventory(string componentLabelName)
        {
            InitializeComponent();
            _componentLabelText = componentLabelName;
        }

        private void powerSupplyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.powerSupplyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pcpProfessionalDataSet);

        }

        private void PowerSupplyAddInventory_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            // TODO: This line of code loads data into the 'pcpProfessionalDataSet.PowerSupply' table. You can move, or remove it, as needed.
            this.powerSupplyTableAdapter.Fill(this.pcpProfessionalDataSet.PowerSupply);
            this.ComponentNameLbl.Text = _componentLabelText;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            var addInventory = new AddInventory();

            FormManager.GotoForm(this, addInventory);
        }
    }
}
