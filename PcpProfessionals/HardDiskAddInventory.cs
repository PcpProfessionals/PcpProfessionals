﻿using System;
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
    public partial class HardDiskAddInventory : Form
    {
        public HardDiskAddInventory()
        {
            InitializeComponent();
        }

        private void harddiskBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.harddiskBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pcpProfessionalDataSet);

        }

        private void HardDiskAddInventory_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            // TODO: This line of code loads data into the 'pcpProfessionalDataSet.Harddisk' table. You can move, or remove it, as needed.
            this.harddiskTableAdapter.Fill(this.pcpProfessionalDataSet.Harddisk);

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            var addInventory = new AddInventory();

            FormManager.GotoForm(this, addInventory);
        }
    }
}
