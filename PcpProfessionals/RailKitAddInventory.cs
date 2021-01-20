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
    public partial class RailKitAddInventory : Form
    {
        private string _componentLabelText;

        public RailKitAddInventory(string componentNameLabel)
        {
            InitializeComponent();
            _componentLabelText = componentNameLabel;
        }

        private void railKitBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.railKitBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pcpProfessionalDataSet);

        }

        private void RailKitAddInventory_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            // TODO: This line of code loads data into the 'pcpProfessionalDataSet.RailKit' table. You can move, or remove it, as needed.
            this.railKitTableAdapter.Fill(this.pcpProfessionalDataSet.RailKit);
            this.ComponentNameLbl.Text = _componentLabelText;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            var addInventory = new AddInventory();

            FormManager.GotoForm(this, addInventory);
        }
    }
}
