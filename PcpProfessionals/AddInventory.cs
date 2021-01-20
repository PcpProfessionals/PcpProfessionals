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
            this.FormBorderStyle = FormBorderStyle.None;
        }


        private void BackPlaneBtn_Click(object sender, EventArgs e)
        {
            var backPlanePage = new BackPlaneAddInventory("BackPlane");
            
            GotoForm(this, backPlanePage);
        }

        private void EthernetCardBtn_Click(object sender, EventArgs e)
        {
            var ethernetCardPage = new EthernetCardAddInventory("Ethernet Card");

            GotoForm(this, ethernetCardPage);
        }

        private void FiberCardBtn_Click(object sender, EventArgs e)
        {
            var fiberCardPage = new FiberCardAddInventory("Fiber Card");

            GotoForm(this, fiberCardPage);
        }

        private void HddCaddyAddInvBtn_Click(object sender, EventArgs e)
        {
            var hddCaddyPage = new HddCaddyAddInventory("HDD Caddy");

            GotoForm(this, hddCaddyPage);
        }

        private void HardDiskAddInvBtn_Click(object sender, EventArgs e)
        {
            var hardDiskPage = new HardDiskAddInventory("HardDisk");


            GotoForm(this, hardDiskPage);
        }

        private void HeatSinkAddInvBtn_Click(object sender, EventArgs e)
        {
            var heatSinkPage = new HeatSinkAddInventory("Heat Sink");

            GotoForm(this, heatSinkPage);
        }

        private void KvmAddInvBtn_Click(object sender, EventArgs e)
        {
            var kvmPage = new KVMAddInventory("KVM");

            GotoForm(this, kvmPage);
        }

        private void LedAddInvBtn_Click(object sender, EventArgs e)
        {
            var ledPage = new LedAddInventory("LED");

            GotoForm(this, ledPage);
        }

        private void MemoryAddInvBtn_Click(object sender, EventArgs e)
        {
            var memoryPage = new MemoryAddInventory("Memory");


            GotoForm(this, memoryPage);
        }

        private void MotherBoardAddInvBtn_Click(object sender, EventArgs e)
        {
            var motherBoardPage = new MotherBoardAddInventory("MotherBoard");

            GotoForm(this, motherBoardPage);
        }

        private void PduAddInvBtn_Click(object sender, EventArgs e)
        {
            var pduPage = new PDUAddInventory("PDU");

            GotoForm(this, pduPage);
        }

        private void PowerSupplyAddInvBtn_Click(object sender, EventArgs e)
        {
            var powerSupplyPage = new PowerSupplyAddInventory("Power Supply");

            GotoForm(this, powerSupplyPage);
        }

        private void ProcessorAddInvBtn_Click(object sender, EventArgs e)
        {
            var processorPage = new ProcessorAddInventory("Processor");

            GotoForm(this, processorPage);
        }

        private void RackAddInvBtn_Click(object sender, EventArgs e)
        {
            var rackPage = new RackAddInventory("Rack");

            GotoForm(this, rackPage);
        }

        private void RaidBttryAddInvBtn_Click(object sender, EventArgs e)
        {
            var raidBatteryPage = new RaidBatteryAddInventory("Raid Battery");

            GotoForm(this, raidBatteryPage);
        }

        private void RailKitAddInvBtn_Click(object sender, EventArgs e)
        {
            var railKitPage = new RailKitAddInventory("Rail Kit");

            GotoForm(this, railKitPage);
        }

        private void RiserCardAddInvBtn_Click(object sender, EventArgs e)
        {
            var riserCardPage = new RiserCardAddInventory("Riser Card");

            GotoForm(this, riserCardPage);
        }

        private void SaasCableAddInvBtn_Click(object sender, EventArgs e)
        {
            var saasCablePage = new SAASCableAddInventory("SAAS Cable");

            GotoForm(this, saasCablePage);
        }

        private void SFPAddInvBtn_Click(object sender, EventArgs e)
        {
            var sfpPage = new SFPAddInventory("SFP");

            GotoForm(this, sfpPage);
        }

        private void StorageAddInvBtn_Click(object sender, EventArgs e)
        {
            var storagePage = new StorageAddInventory("Storage");

            GotoForm(this, storagePage);
        }

        private void SwitchAddInvBtn_Click(object sender, EventArgs e)
        {
            var switchPage = new SwitchAddInventory("Switch");

            GotoForm(this, switchPage);
        }

        private void TFTConsoleAddInvBtn_Click(object sender, EventArgs e)
        {
            var tftConsolePage = new TFTConsoleAddInventory("TFT Console");

            GotoForm(this, tftConsolePage);
        }

        private void ThinClientAddInvBtn_Click(object sender, EventArgs e)
        {
            var thinClientPage = new ThinClientAddInventory("Thin Client");

            GotoForm(this, thinClientPage);
        }

        private void ZeroClientAddInvBtn_Click(object sender, EventArgs e)
        {
            var zeroClientPage = new ZeroClientAddInventory("Zero Client");

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
