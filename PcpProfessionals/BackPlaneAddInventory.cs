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
    public partial class BackPlaneAddInventory : Form
    {
        public BackPlaneAddInventory()
        {
            InitializeComponent();
            
        }

        private void backPlaneBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.backPlaneBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pcpProfessionalDataSet);

        }

        private void BackPlaneAddInventory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pcpProfessionalDataSet.BackPlane' table. You can move, or remove it, as needed.
            this.backPlaneTableAdapter.Fill(this.pcpProfessionalDataSet.BackPlane);

        }

        void purchaseDateTimePicker_BindingComplete(object sender, BindingCompleteEventArgs e)
        {
            if(e.BindingCompleteState == BindingCompleteState.Success)
            {
                MessageBox.Show("Error", e.ErrorText);
            }
        }
    }
}
