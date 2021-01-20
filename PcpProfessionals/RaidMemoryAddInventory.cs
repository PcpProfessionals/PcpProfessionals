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
    public partial class RaidMemoryAddInventory : Form
    {
        private string _componentLabelText;

        public RaidMemoryAddInventory(string componentNameLabel)
        {
            InitializeComponent();
            _componentLabelText = componentNameLabel;
        }

        private void raidBatteryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.raidBatteryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pcpProfessionalDataSet);

        }

        private void RaidMemoryAddInventory_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            // TODO: This line of code loads data into the 'pcpProfessionalDataSet.RaidBattery' table. You can move, or remove it, as needed.
            this.raidBatteryTableAdapter.Fill(this.pcpProfessionalDataSet.RaidBattery);
            this.ComponentNameLbl.Text = _componentLabelText;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            var addInventory = new AddInventory();

            FormManager.GotoForm(this, addInventory);
        }
    }
}
