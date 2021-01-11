using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PcpProfessionals
{
    public partial class HddCaddyAddInventory : Form
    {
        public HddCaddyAddInventory()
        {
            InitializeComponent();
        }

        private void hddCadyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hddCadyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pcpProfessionalDataSet);

        }

        private void HddCaddyAddInventory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pcpProfessionalDataSet.HddCady' table. You can move, or remove it, as needed.
            this.hddCadyTableAdapter.Fill(this.pcpProfessionalDataSet.HddCady);

        }
    }
}
