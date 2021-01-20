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
    public partial class SearchInventory : Form
    {
        public SearchInventory()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            var inventoryPage = new InventoryPage();

            FormManager.GotoForm(this, inventoryPage);
        }

        private void SearchInventory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pcpProfessionalDataSet.TFTConsole' table. You can move, or remove it, as needed.
            this.tFTConsoleTableAdapter.Fill(this.pcpProfessionalDataSet.TFTConsole);
            // TODO: This line of code loads data into the 'pcpProfessionalDataSet.ZeroClient' table. You can move, or remove it, as needed.
            this.zeroClientTableAdapter.Fill(this.pcpProfessionalDataSet.ZeroClient);
            // TODO: This line of code loads data into the 'pcpProfessionalDataSet.ThinClient' table. You can move, or remove it, as needed.
            this.thinClientTableAdapter.Fill(this.pcpProfessionalDataSet.ThinClient);
            // TODO: This line of code loads data into the 'pcpProfessionalDataSet.Switch' table. You can move, or remove it, as needed.
            this.switchTableAdapter.Fill(this.pcpProfessionalDataSet.Switch);
            // TODO: This line of code loads data into the 'pcpProfessionalDataSet.Storage' table. You can move, or remove it, as needed.
            this.storageTableAdapter.Fill(this.pcpProfessionalDataSet.Storage);
            // TODO: This line of code loads data into the 'pcpProfessionalDataSet.SFP' table. You can move, or remove it, as needed.
            this.sFPTableAdapter.Fill(this.pcpProfessionalDataSet.SFP);
            // TODO: This line of code loads data into the 'pcpProfessionalDataSet.SAASCable' table. You can move, or remove it, as needed.
            this.sAASCableTableAdapter.Fill(this.pcpProfessionalDataSet.SAASCable);
            // TODO: This line of code loads data into the 'pcpProfessionalDataSet.RiserCard' table. You can move, or remove it, as needed.
            this.riserCardTableAdapter.Fill(this.pcpProfessionalDataSet.RiserCard);
            // TODO: This line of code loads data into the 'pcpProfessionalDataSet.RailKit' table. You can move, or remove it, as needed.
            this.railKitTableAdapter.Fill(this.pcpProfessionalDataSet.RailKit);
            // TODO: This line of code loads data into the 'pcpProfessionalDataSet.RaidMemory' table. You can move, or remove it, as needed.
            this.raidMemoryTableAdapter.Fill(this.pcpProfessionalDataSet.RaidMemory);
            // TODO: This line of code loads data into the 'pcpProfessionalDataSet.RaidBattery' table. You can move, or remove it, as needed.
            this.raidBatteryTableAdapter.Fill(this.pcpProfessionalDataSet.RaidBattery);
            // TODO: This line of code loads data into the 'pcpProfessionalDataSet.Rack' table. You can move, or remove it, as needed.
            this.rackTableAdapter.Fill(this.pcpProfessionalDataSet.Rack);
            // TODO: This line of code loads data into the 'pcpProfessionalDataSet.PowerSupply' table. You can move, or remove it, as needed.
            this.powerSupplyTableAdapter.Fill(this.pcpProfessionalDataSet.PowerSupply);
            // TODO: This line of code loads data into the 'pcpProfessionalDataSet.PDU' table. You can move, or remove it, as needed.
            this.pDUTableAdapter.Fill(this.pcpProfessionalDataSet.PDU);
            // TODO: This line of code loads data into the 'pcpProfessionalDataSet.MotherBroad' table. You can move, or remove it, as needed.
            this.motherBroadTableAdapter.Fill(this.pcpProfessionalDataSet.MotherBroad);
            // TODO: This line of code loads data into the 'pcpProfessionalDataSet.EthernetCard' table. You can move, or remove it, as needed.
            this.ethernetCardTableAdapter.Fill(this.pcpProfessionalDataSet.EthernetCard);
            // TODO: This line of code loads data into the 'pcpProfessionalDataSet.BackPlane' table. You can move, or remove it, as needed.
            this.backPlaneTableAdapter.Fill(this.pcpProfessionalDataSet.BackPlane);
            // TODO: This line of code loads data into the 'pcpProfessionalDataSet.Harddisk' table. You can move, or remove it, as needed.
            this.harddiskTableAdapter.Fill(this.pcpProfessionalDataSet.Harddisk);
            // TODO: This line of code loads data into the 'pcpProfessionalDataSet.FiberCard' table. You can move, or remove it, as needed.
            this.fiberCardTableAdapter.Fill(this.pcpProfessionalDataSet.FiberCard);
            // TODO: This line of code loads data into the 'pcpProfessionalDataSet.HddCady' table. You can move, or remove it, as needed.
            this.hddCadyTableAdapter.Fill(this.pcpProfessionalDataSet.HddCady);
            // TODO: This line of code loads data into the 'pcpProfessionalDataSet.HeatSink' table. You can move, or remove it, as needed.
            this.heatSinkTableAdapter.Fill(this.pcpProfessionalDataSet.HeatSink);

            // TODO: This line of code loads data into the 'pcpProfessionalDataSet.KVM' table. You can move, or remove it, as needed.
            this.kVMTableAdapter.Fill(this.pcpProfessionalDataSet.KVM);
            // TODO: This line of code loads data into the 'pcpProfessionalDataSet.LED' table. You can move, or remove it, as needed.
            this.lEDTableAdapter.Fill(this.pcpProfessionalDataSet.LED);
            // TODO: This line of code loads data into the 'pcpProfessionalDataSet.Memory' table. You can move, or remove it, as needed.
            this.memoryTableAdapter.Fill(this.pcpProfessionalDataSet.Memory);
        }
    }
}
