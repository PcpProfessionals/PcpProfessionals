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
    public partial class FiberCardAddInventory : Form
    {
        public FiberCardAddInventory()
        {
            InitializeComponent();
        }

        private void fiberCardBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fiberCardBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pcpProfessionalDataSet);

        }

        private void FiberCardAddInventory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pcpProfessionalDataSet.FiberCard' table. You can move, or remove it, as needed.
            this.fiberCardTableAdapter.Fill(this.pcpProfessionalDataSet.FiberCard);

        }
    }
}
