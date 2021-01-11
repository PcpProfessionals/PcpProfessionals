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
    public partial class HeatSinkAddInventory : Form
    {
        public HeatSinkAddInventory()
        {
            InitializeComponent();
        }

        private void heatSinkBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.heatSinkBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pcpProfessionalDataSet);

        }

        private void HeatSinkAddInventory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pcpProfessionalDataSet.HeatSink' table. You can move, or remove it, as needed.
            this.heatSinkTableAdapter.Fill(this.pcpProfessionalDataSet.HeatSink);

        }
    }
}
