
using System;

namespace PcpProfessionals
{
    partial class BackPlaneAddInventory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackPlaneAddInventory));
            System.Windows.Forms.Label typeLabel;
            System.Windows.Forms.Label sizeLabel;
            System.Windows.Forms.Label numberOfPortsLabel;
            System.Windows.Forms.Label purchaseDateLabel;
            this.pcpProfessionalDataSet = new PcpProfessionals.PcpProfessionalDataSet();
            this.backPlaneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.backPlaneTableAdapter = new PcpProfessionals.PcpProfessionalDataSetTableAdapters.BackPlaneTableAdapter();
            this.tableAdapterManager = new PcpProfessionals.PcpProfessionalDataSetTableAdapters.TableAdapterManager();
            this.backPlaneBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.backPlaneBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.sizeTextBox = new System.Windows.Forms.TextBox();
            this.numberOfPortsTextBox = new System.Windows.Forms.TextBox();
            this.purchaseDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            typeLabel = new System.Windows.Forms.Label();
            sizeLabel = new System.Windows.Forms.Label();
            numberOfPortsLabel = new System.Windows.Forms.Label();
            purchaseDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcpProfessionalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backPlaneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backPlaneBindingNavigator)).BeginInit();
            this.backPlaneBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcpProfessionalDataSet
            // 
            this.pcpProfessionalDataSet.DataSetName = "PcpProfessionalDataSet";
            this.pcpProfessionalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // backPlaneBindingSource
            // 
            this.backPlaneBindingSource.DataMember = "BackPlane";
            this.backPlaneBindingSource.DataSource = this.pcpProfessionalDataSet;
            // 
            // backPlaneTableAdapter
            // 
            this.backPlaneTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackPlaneTableAdapter = this.backPlaneTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BrandTableAdapter = null;
            this.tableAdapterManager.EthernetCardTableAdapter = null;
            this.tableAdapterManager.FiberCardTableAdapter = null;
            this.tableAdapterManager.HarddiskTableAdapter = null;
            this.tableAdapterManager.HddCadyTableAdapter = null;
            this.tableAdapterManager.HeatSinkTableAdapter = null;
            this.tableAdapterManager.KVMTableAdapter = null;
            this.tableAdapterManager.LEDTableAdapter = null;
            this.tableAdapterManager.ManagerTableAdapter = null;
            this.tableAdapterManager.MemoryTableAdapter = null;
            this.tableAdapterManager.MotherBroadTableAdapter = null;
            this.tableAdapterManager.PDUTableAdapter = null;
            this.tableAdapterManager.PowerSupplyTableAdapter = null;
            this.tableAdapterManager.ProcessorTableAdapter = null;
            this.tableAdapterManager.RackTableAdapter = null;
            this.tableAdapterManager.RaidBatteryTableAdapter = null;
            this.tableAdapterManager.RaidCardTableAdapter = null;
            this.tableAdapterManager.RaidMemoryTableAdapter = null;
            this.tableAdapterManager.RailKitTableAdapter = null;
            this.tableAdapterManager.RiserCardTableAdapter = null;
            this.tableAdapterManager.SAASCableTableAdapter = null;
            this.tableAdapterManager.SFPTableAdapter = null;
            this.tableAdapterManager.StorageTableAdapter = null;
            this.tableAdapterManager.SwitchTableAdapter = null;
            this.tableAdapterManager.TFTConsoleTableAdapter = null;
            this.tableAdapterManager.ThinClientTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PcpProfessionals.PcpProfessionalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            this.tableAdapterManager.ZeroClientTableAdapter = null;
            // 
            // backPlaneBindingNavigator
            // 
            this.backPlaneBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.backPlaneBindingNavigator.BindingSource = this.backPlaneBindingSource;
            this.backPlaneBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.backPlaneBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.backPlaneBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.backPlaneBindingNavigatorSaveItem});
            this.backPlaneBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.backPlaneBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.backPlaneBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.backPlaneBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.backPlaneBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.backPlaneBindingNavigator.Name = "backPlaneBindingNavigator";
            this.backPlaneBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.backPlaneBindingNavigator.Size = new System.Drawing.Size(511, 25);
            this.backPlaneBindingNavigator.TabIndex = 0;
            this.backPlaneBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // backPlaneBindingNavigatorSaveItem
            // 
            this.backPlaneBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.backPlaneBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("backPlaneBindingNavigatorSaveItem.Image")));
            this.backPlaneBindingNavigatorSaveItem.Name = "backPlaneBindingNavigatorSaveItem";
            this.backPlaneBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.backPlaneBindingNavigatorSaveItem.Text = "Save Data";
            this.backPlaneBindingNavigatorSaveItem.Click += new System.EventHandler(this.backPlaneBindingNavigatorSaveItem_Click);
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new System.Drawing.Point(41, 59);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(34, 13);
            typeLabel.TabIndex = 1;
            typeLabel.Text = "Type:";
            // 
            // typeTextBox
            // 
            this.typeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.backPlaneBindingSource, "Type", true));
            this.typeTextBox.Location = new System.Drawing.Point(93, 56);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(100, 20);
            this.typeTextBox.TabIndex = 2;
            // 
            // sizeLabel
            // 
            sizeLabel.AutoSize = true;
            sizeLabel.Location = new System.Drawing.Point(41, 107);
            sizeLabel.Name = "sizeLabel";
            sizeLabel.Size = new System.Drawing.Size(30, 13);
            sizeLabel.TabIndex = 3;
            sizeLabel.Text = "Size:";
            // 
            // sizeTextBox
            // 
            this.sizeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.backPlaneBindingSource, "Size", true));
            this.sizeTextBox.Location = new System.Drawing.Point(96, 104);
            this.sizeTextBox.Name = "sizeTextBox";
            this.sizeTextBox.Size = new System.Drawing.Size(100, 20);
            this.sizeTextBox.TabIndex = 4;
            // 
            // numberOfPortsLabel
            // 
            numberOfPortsLabel.AutoSize = true;
            numberOfPortsLabel.Location = new System.Drawing.Point(228, 63);
            numberOfPortsLabel.Name = "numberOfPortsLabel";
            numberOfPortsLabel.Size = new System.Drawing.Size(88, 13);
            numberOfPortsLabel.TabIndex = 5;
            numberOfPortsLabel.Text = "Number Of Ports:";
            // 
            // numberOfPortsTextBox
            // 
            this.numberOfPortsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.backPlaneBindingSource, "NumberOfPorts", true));
            this.numberOfPortsTextBox.Location = new System.Drawing.Point(322, 59);
            this.numberOfPortsTextBox.Name = "numberOfPortsTextBox";
            this.numberOfPortsTextBox.Size = new System.Drawing.Size(100, 20);
            this.numberOfPortsTextBox.TabIndex = 6;
            // 
            // purchaseDateLabel
            // 
            purchaseDateLabel.AutoSize = true;
            purchaseDateLabel.Location = new System.Drawing.Point(41, 165);
            purchaseDateLabel.Name = "purchaseDateLabel";
            purchaseDateLabel.Size = new System.Drawing.Size(81, 13);
            purchaseDateLabel.TabIndex = 7;
            purchaseDateLabel.Text = "Purchase Date:";
            // 
            // purchaseDateDateTimePicker
            // 
            this.purchaseDateDateTimePicker.Value = DateTime.Now;
            this.purchaseDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.backPlaneBindingSource, "PurchaseDate", true,System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.purchaseDateDateTimePicker.Location = new System.Drawing.Point(141, 165);
            this.purchaseDateDateTimePicker.Name = "purchaseDateDateTimePicker";
            this.purchaseDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.purchaseDateDateTimePicker.TabIndex = 8;
            
            // 
            // BackPlaneAddInventory
            // 
            this.ClientSize = new System.Drawing.Size(511, 277);
            this.Controls.Add(purchaseDateLabel);
            this.Controls.Add(this.purchaseDateDateTimePicker);
            this.Controls.Add(numberOfPortsLabel);
            this.Controls.Add(this.numberOfPortsTextBox);
            this.Controls.Add(sizeLabel);
            this.Controls.Add(this.sizeTextBox);
            this.Controls.Add(typeLabel);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(this.backPlaneBindingNavigator);
            this.Name = "BackPlaneAddInventory";
            this.Load += new System.EventHandler(this.BackPlaneAddInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcpProfessionalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backPlaneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backPlaneBindingNavigator)).EndInit();
            this.backPlaneBindingNavigator.ResumeLayout(false);
            this.backPlaneBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private PcpProfessionalDataSet pcpProfessionalDataSet;
        private System.Windows.Forms.BindingSource backPlaneBindingSource;
        private PcpProfessionalDataSetTableAdapters.BackPlaneTableAdapter backPlaneTableAdapter;
        private PcpProfessionalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator backPlaneBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton backPlaneBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.TextBox sizeTextBox;
        private System.Windows.Forms.TextBox numberOfPortsTextBox;
        private System.Windows.Forms.DateTimePicker purchaseDateDateTimePicker;
    }
}