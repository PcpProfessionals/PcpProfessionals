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
    public partial class EthernetCardAddInventory : Form
    {
        public EthernetCardAddInventory()
        {
            InitializeComponent();
        }

        private void ethernetCardBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ethernetCardBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pcpProfessionalDataSet);

        }

        private void EthernetCardAddInventory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pcpProfessionalDataSet.EthernetCard' table. You can move, or remove it, as needed.
            this.ethernetCardTableAdapter.Fill(this.pcpProfessionalDataSet.EthernetCard);

        }
    }
}
