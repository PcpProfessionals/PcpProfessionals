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
using Utilities;

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


        private void BackPlaneBtn_Click(object sender, EventArgs e)
        {
            var backPlanePage = new BackPlaneAddInventory();

            GotoForm(this, backPlanePage);
        }

        private void EthernetCardBtn_Click(object sender, EventArgs e)
        {
            var ethernetCardPage = new EthernetCardAddInventory();

            GotoForm(this, ethernetCardPage);
        }

        private void FiberCardBtn_Click(object sender, EventArgs e)
        {
            var fiberCardPage = new FiberCardAddInventory();

            GotoForm(this, fiberCardPage);
        }

        private void HddCaddyAddInvBtn_Click(object sender, EventArgs e)
        {
            var hddCaddyPage = new HddCaddyAddInventory();

            GotoForm(this, hddCaddyPage);
        }

        private void HardDiskAddInvBtn_Click(object sender, EventArgs e)
        {
            var hardDiskPage = new HardDiskAddInventory();


            GotoForm(this, hardDiskPage);
        }

        private void HeatSinkAddInvBtn_Click(object sender, EventArgs e)
        {
            var heatSinkPage = new HeatSinkAddInventory();

            GotoForm(this, heatSinkPage);
        }

        private void KvmAddInvBtn_Click(object sender, EventArgs e)
        {
            var kvmPage = new KVMAddInventory();

            GotoForm(this, kvmPage);
        }

        private void LedAddInvBtn_Click(object sender, EventArgs e)
        {
            var ledPage = new LedAddInventory();

            GotoForm(this, ledPage);
        }

        private void MemoryAddInvBtn_Click(object sender, EventArgs e)
        {
            var memoryPage = new MemoryAddInventory();


            GotoForm(this, memoryPage);
        }

        private void MotherBoardAddInvBtn_Click(object sender, EventArgs e)
        {
            var motherBoardPage = new MotherBoardAddInventory();

            GotoForm(this, motherBoardPage);
        }

        private void PduAddInvBtn_Click(object sender, EventArgs e)
        {
            var pduPage = new PDUAddInventory();

            GotoForm(this, pduPage);
        }

        private void PowerSupplyAddInvBtn_Click(object sender, EventArgs e)
        {
            var powerSupplyPage = new PowerSupplyAddInventory();

            GotoForm(this, powerSupplyPage);
        }

        private void ProcessorAddInvBtn_Click(object sender, EventArgs e)
        {
            var processorPage = new ProcessorAddInventory();

            GotoForm(this, processorPage);
        }

        private void RackAddInvBtn_Click(object sender, EventArgs e)
        {
            var rackPage = new RackAddInventory();

            GotoForm(this, rackPage);
        }

        private void RaidBttryAddInvBtn_Click(object sender, EventArgs e)
        {
            var raidBatteryPage = new RaidBatteryAddInventory();

            GotoForm(this, raidBatteryPage);
        }

        private void RailKitAddInvBtn_Click(object sender, EventArgs e)
        {
            var railKitPage = new RailKitAddInventory();

            GotoForm(this, railKitPage);
        }

        private void RiserCardAddInvBtn_Click(object sender, EventArgs e)
        {
            var riserCardPage = new RiserCardAddInventory();

            GotoForm(this, riserCardPage);
        }

        private void SaasCableAddInvBtn_Click(object sender, EventArgs e)
        {
            var saasCablePage = new SAASCableAddInventory();

            GotoForm(this, saasCablePage);
        }

        private void SFPAddInvBtn_Click(object sender, EventArgs e)
        {
            var sfpPage = new SFPAddInventory();

            GotoForm(this, sfpPage);
        }

        private void StorageAddInvBtn_Click(object sender, EventArgs e)
        {
            var storagePage = new StorageAddInventory();

            GotoForm(this, storagePage);
        }

        private void SwitchAddInvBtn_Click(object sender, EventArgs e)
        {
            var switchPage = new SwitchAddInventory();

            GotoForm(this, switchPage);
        }

        private void TFTConsoleAddInvBtn_Click(object sender, EventArgs e)
        {
            var tftConsolePage = new TFTConsoleAddInventory();

            GotoForm(this, tftConsolePage);
        }

        private void ThinClientAddInvBtn_Click(object sender, EventArgs e)
        {
            var thinClientPage = new ThinClientAddInventory();

            GotoForm(this, thinClientPage);
        }

        private void ZeroClientAddInvBtn_Click(object sender, EventArgs e)
        {
            var zeroClientPage = new ZeroClientAddInventory();

            GotoForm(this, zeroClientPage);
        }

        private void GotoForm(Form currentForm, Form targetForm)
        {
            currentForm.Hide();
            targetForm.ShowDialog();
            currentForm.Close();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            var inventoryPage = new InventoryPage();

            FormManager.GotoForm(this, inventoryPage);
        }
    }
}
