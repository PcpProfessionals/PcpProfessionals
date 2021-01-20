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
    public partial class MotherBoardAddInventory : Form
    {
        private string _componentLabelText;

        public MotherBoardAddInventory()
        {

        }

        public MotherBoardAddInventory(string componentNameLabel)
        {
            InitializeComponent();
            _componentLabelText = componentNameLabel;
        }

        private void motherBroadBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.motherBroadBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pcpProfessionalDataSet);

        }

        private void MotherBoardAddInventory_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            // TODO: This line of code loads data into the 'pcpProfessionalDataSet.MotherBroad' table. You can move, or remove it, as needed.
            this.motherBroadTableAdapter.Fill(this.pcpProfessionalDataSet.MotherBroad);
            this.ComponentNameLbl.Text = _componentLabelText;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            var addInventory = new AddInventory();

            FormManager.GotoForm(this, addInventory);
        }
    }
}
