
namespace PcpProfessionals
{
    partial class FiberCardAddInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FiberCardAddInventory));
            System.Windows.Forms.Label modelNumberLabel;
            System.Windows.Forms.Label transferRateLabel;
            System.Windows.Forms.Label numberOfPortsLabel;
            System.Windows.Forms.Label purchaseDateLabel;
            this.pcpProfessionalDataSet = new PcpProfessionals.PcpProfessionalDataSet();
            this.fiberCardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fiberCardTableAdapter = new PcpProfessionals.PcpProfessionalDataSetTableAdapters.FiberCardTableAdapter();
            this.tableAdapterManager = new PcpProfessionals.PcpProfessionalDataSetTableAdapters.TableAdapterManager();
            this.fiberCardBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.fiberCardBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.modelNumberTextBox = new System.Windows.Forms.TextBox();
            this.transferRateTextBox = new System.Windows.Forms.TextBox();
            this.numberOfPortsTextBox = new System.Windows.Forms.TextBox();
            this.purchaseDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            modelNumberLabel = new System.Windows.Forms.Label();
            transferRateLabel = new System.Windows.Forms.Label();
            numberOfPortsLabel = new System.Windows.Forms.Label();
            purchaseDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcpProfessionalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiberCardBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiberCardBindingNavigator)).BeginInit();
            this.fiberCardBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcpProfessionalDataSet
            // 
            this.pcpProfessionalDataSet.DataSetName = "PcpProfessionalDataSet";
            this.pcpProfessionalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fiberCardBindingSource
            // 
            this.fiberCardBindingSource.DataMember = "FiberCard";
            this.fiberCardBindingSource.DataSource = this.pcpProfessionalDataSet;
            // 
            // fiberCardTableAdapter
            // 
            this.fiberCardTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackPlaneTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BrandTableAdapter = null;
            this.tableAdapterManager.EthernetCardTableAdapter = null;
            this.tableAdapterManager.FiberCardTableAdapter = this.fiberCardTableAdapter;
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
            // fiberCardBindingNavigator
            // 
            this.fiberCardBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.fiberCardBindingNavigator.BindingSource = this.fiberCardBindingSource;
            this.fiberCardBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.fiberCardBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.fiberCardBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.fiberCardBindingNavigatorSaveItem});
            this.fiberCardBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.fiberCardBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.fiberCardBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.fiberCardBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.fiberCardBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.fiberCardBindingNavigator.Name = "fiberCardBindingNavigator";
            this.fiberCardBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.fiberCardBindingNavigator.Size = new System.Drawing.Size(587, 25);
            this.fiberCardBindingNavigator.TabIndex = 0;
            this.fiberCardBindingNavigator.Text = "bindingNavigator1";
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
            // fiberCardBindingNavigatorSaveItem
            // 
            this.fiberCardBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fiberCardBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("fiberCardBindingNavigatorSaveItem.Image")));
            this.fiberCardBindingNavigatorSaveItem.Name = "fiberCardBindingNavigatorSaveItem";
            this.fiberCardBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.fiberCardBindingNavigatorSaveItem.Text = "Save Data";
            this.fiberCardBindingNavigatorSaveItem.Click += new System.EventHandler(this.fiberCardBindingNavigatorSaveItem_Click);
            // 
            // modelNumberLabel
            // 
            modelNumberLabel.AutoSize = true;
            modelNumberLabel.Location = new System.Drawing.Point(27, 62);
            modelNumberLabel.Name = "modelNumberLabel";
            modelNumberLabel.Size = new System.Drawing.Size(79, 13);
            modelNumberLabel.TabIndex = 1;
            modelNumberLabel.Text = "Model Number:";
            // 
            // modelNumberTextBox
            // 
            this.modelNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fiberCardBindingSource, "ModelNumber", true));
            this.modelNumberTextBox.Location = new System.Drawing.Point(112, 59);
            this.modelNumberTextBox.Name = "modelNumberTextBox";
            this.modelNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.modelNumberTextBox.TabIndex = 2;
            // 
            // transferRateLabel
            // 
            transferRateLabel.AutoSize = true;
            transferRateLabel.Location = new System.Drawing.Point(27, 118);
            transferRateLabel.Name = "transferRateLabel";
            transferRateLabel.Size = new System.Drawing.Size(75, 13);
            transferRateLabel.TabIndex = 3;
            transferRateLabel.Text = "Transfer Rate:";
            // 
            // transferRateTextBox
            // 
            this.transferRateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fiberCardBindingSource, "TransferRate", true));
            this.transferRateTextBox.Location = new System.Drawing.Point(114, 118);
            this.transferRateTextBox.Name = "transferRateTextBox";
            this.transferRateTextBox.Size = new System.Drawing.Size(100, 20);
            this.transferRateTextBox.TabIndex = 4;
            // 
            // numberOfPortsLabel
            // 
            numberOfPortsLabel.AutoSize = true;
            numberOfPortsLabel.Location = new System.Drawing.Point(275, 62);
            numberOfPortsLabel.Name = "numberOfPortsLabel";
            numberOfPortsLabel.Size = new System.Drawing.Size(88, 13);
            numberOfPortsLabel.TabIndex = 5;
            numberOfPortsLabel.Text = "Number Of Ports:";
            // 
            // numberOfPortsTextBox
            // 
            this.numberOfPortsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fiberCardBindingSource, "NumberOfPorts", true));
            this.numberOfPortsTextBox.Location = new System.Drawing.Point(400, 62);
            this.numberOfPortsTextBox.Name = "numberOfPortsTextBox";
            this.numberOfPortsTextBox.Size = new System.Drawing.Size(100, 20);
            this.numberOfPortsTextBox.TabIndex = 6;
            // 
            // purchaseDateLabel
            // 
            purchaseDateLabel.AutoSize = true;
            purchaseDateLabel.Location = new System.Drawing.Point(27, 174);
            purchaseDateLabel.Name = "purchaseDateLabel";
            purchaseDateLabel.Size = new System.Drawing.Size(81, 13);
            purchaseDateLabel.TabIndex = 7;
            purchaseDateLabel.Text = "Purchase Date:";
            // 
            // purchaseDateDateTimePicker
            // 
            this.purchaseDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.fiberCardBindingSource, "PurchaseDate", true));
            this.purchaseDateDateTimePicker.Location = new System.Drawing.Point(112, 174);
            this.purchaseDateDateTimePicker.Name = "purchaseDateDateTimePicker";
            this.purchaseDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.purchaseDateDateTimePicker.TabIndex = 8;
            // 
            // FiberCardAddInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 272);
            this.Controls.Add(purchaseDateLabel);
            this.Controls.Add(this.purchaseDateDateTimePicker);
            this.Controls.Add(numberOfPortsLabel);
            this.Controls.Add(this.numberOfPortsTextBox);
            this.Controls.Add(transferRateLabel);
            this.Controls.Add(this.transferRateTextBox);
            this.Controls.Add(modelNumberLabel);
            this.Controls.Add(this.modelNumberTextBox);
            this.Controls.Add(this.fiberCardBindingNavigator);
            this.Name = "FiberCardAddInventory";
            this.Text = "FiberCardAddInventory";
            this.Load += new System.EventHandler(this.FiberCardAddInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcpProfessionalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiberCardBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiberCardBindingNavigator)).EndInit();
            this.fiberCardBindingNavigator.ResumeLayout(false);
            this.fiberCardBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PcpProfessionalDataSet pcpProfessionalDataSet;
        private System.Windows.Forms.BindingSource fiberCardBindingSource;
        private PcpProfessionalDataSetTableAdapters.FiberCardTableAdapter fiberCardTableAdapter;
        private PcpProfessionalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator fiberCardBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton fiberCardBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox modelNumberTextBox;
        private System.Windows.Forms.TextBox transferRateTextBox;
        private System.Windows.Forms.TextBox numberOfPortsTextBox;
        private System.Windows.Forms.DateTimePicker purchaseDateDateTimePicker;
    }
}