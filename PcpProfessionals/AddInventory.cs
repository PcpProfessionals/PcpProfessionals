using BL.Services;
using BL.Services.Interfaces;
using DAL.DatabaseObjects;
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
    public partial class AddInventory : Form
    {
        private IComponentService _componentService;

        public AddInventory()
        {
            _componentService = new ComponentService();
            InitializeComponent();
        }

        
        private void AddInventory_Load(object sender, EventArgs e)
        {
            
        }

        private void ComponentListCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void backPlaneBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void BackPlaneBtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
