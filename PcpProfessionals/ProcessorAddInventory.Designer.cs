
namespace PcpProfessionals
{
    partial class ProcessorAddInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcessorAddInventory));
            System.Windows.Forms.Label modelNumberLabel;
            System.Windows.Forms.Label cacheSizeLabel;
            System.Windows.Forms.Label numberOfPortsLabel;
            System.Windows.Forms.Label typeLabel;
            System.Windows.Forms.Label speedLabel;
            System.Windows.Forms.Label purchaseDateLabel;
            System.Windows.Forms.Label quantityLabel;
            System.Windows.Forms.Label unitPriceLabel;
            this.pcpProfessionalDataSet = new PcpProfessionals.PcpProfessionalDataSet();
            this.processorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.processorTableAdapter = new PcpProfessionals.PcpProfessionalDataSetTableAdapters.ProcessorTableAdapter();
            this.tableAdapterManager = new PcpProfessionals.PcpProfessionalDataSetTableAdapters.TableAdapterManager();
            this.processorBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.processorBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.modelNumberTextBox = new System.Windows.Forms.TextBox();
            this.cacheSizeTextBox = new System.Windows.Forms.TextBox();
            this.numberOfPortsTextBox = new System.Windows.Forms.TextBox();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.speedTextBox = new System.Windows.Forms.TextBox();
            this.purchaseDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.unitPriceTextBox = new System.Windows.Forms.TextBox();
            this.BackBtn = new System.Windows.Forms.Label();
            modelNumberLabel = new System.Windows.Forms.Label();
            cacheSizeLabel = new System.Windows.Forms.Label();
            numberOfPortsLabel = new System.Windows.Forms.Label();
            typeLabel = new System.Windows.Forms.Label();
            speedLabel = new System.Windows.Forms.Label();
            purchaseDateLabel = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            unitPriceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcpProfessionalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processorBindingNavigator)).BeginInit();
            this.processorBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcpProfessionalDataSet
            // 
            this.pcpProfessionalDataSet.DataSetName = "PcpProfessionalDataSet";
            this.pcpProfessionalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // processorBindingSource
            // 
            this.processorBindingSource.DataMember = "Processor";
            this.processorBindingSource.DataSource = this.pcpProfessionalDataSet;
            // 
            // processorTableAdapter
            // 
            this.processorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackPlaneTableAdapter = null;
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
            this.tableAdapterManager.ProcessorTableAdapter = this.processorTableAdapter;
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
            // processorBindingNavigator
            // 
            this.processorBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.processorBindingNavigator.BindingSource = this.processorBindingSource;
            this.processorBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.processorBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.processorBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.processorBindingNavigatorSaveItem});
            this.processorBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.processorBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.processorBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.processorBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.processorBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.processorBindingNavigator.Name = "processorBindingNavigator";
            this.processorBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.processorBindingNavigator.Size = new System.Drawing.Size(676, 25);
            this.processorBindingNavigator.TabIndex = 0;
            this.processorBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // processorBindingNavigatorSaveItem
            // 
            this.processorBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.processorBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("processorBindingNavigatorSaveItem.Image")));
            this.processorBindingNavigatorSaveItem.Name = "processorBindingNavigatorSaveItem";
            this.processorBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.processorBindingNavigatorSaveItem.Text = "Save Data";
            this.processorBindingNavigatorSaveItem.Click += new System.EventHandler(this.processorBindingNavigatorSaveItem_Click);
            // 
            // modelNumberLabel
            // 
            modelNumberLabel.AutoSize = true;
            modelNumberLabel.Location = new System.Drawing.Point(37, 62);
            modelNumberLabel.Name = "modelNumberLabel";
            modelNumberLabel.Size = new System.Drawing.Size(79, 13);
            modelNumberLabel.TabIndex = 1;
            modelNumberLabel.Text = "Model Number:";
            // 
            // modelNumberTextBox
            // 
            this.modelNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.processorBindingSource, "ModelNumber", true));
            this.modelNumberTextBox.Location = new System.Drawing.Point(145, 55);
            this.modelNumberTextBox.Name = "modelNumberTextBox";
            this.modelNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.modelNumberTextBox.TabIndex = 2;
            // 
            // cacheSizeLabel
            // 
            cacheSizeLabel.AutoSize = true;
            cacheSizeLabel.Location = new System.Drawing.Point(342, 67);
            cacheSizeLabel.Name = "cacheSizeLabel";
            cacheSizeLabel.Size = new System.Drawing.Size(64, 13);
            cacheSizeLabel.TabIndex = 3;
            cacheSizeLabel.Text = "Cache Size:";
            // 
            // cacheSizeTextBox
            // 
            this.cacheSizeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.processorBindingSource, "CacheSize", true));
            this.cacheSizeTextBox.Location = new System.Drawing.Point(412, 64);
            this.cacheSizeTextBox.Name = "cacheSizeTextBox";
            this.cacheSizeTextBox.Size = new System.Drawing.Size(100, 20);
            this.cacheSizeTextBox.TabIndex = 4;
            // 
            // numberOfPortsLabel
            // 
            numberOfPortsLabel.AutoSize = true;
            numberOfPortsLabel.Location = new System.Drawing.Point(37, 101);
            numberOfPortsLabel.Name = "numberOfPortsLabel";
            numberOfPortsLabel.Size = new System.Drawing.Size(88, 13);
            numberOfPortsLabel.TabIndex = 5;
            numberOfPortsLabel.Text = "Number Of Ports:";
            // 
            // numberOfPortsTextBox
            // 
            this.numberOfPortsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.processorBindingSource, "NumberOfPorts", true));
            this.numberOfPortsTextBox.Location = new System.Drawing.Point(145, 94);
            this.numberOfPortsTextBox.Name = "numberOfPortsTextBox";
            this.numberOfPortsTextBox.Size = new System.Drawing.Size(100, 20);
            this.numberOfPortsTextBox.TabIndex = 6;
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new System.Drawing.Point(342, 137);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(34, 13);
            typeLabel.TabIndex = 7;
            typeLabel.Text = "Type:";
            // 
            // typeTextBox
            // 
            this.typeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.processorBindingSource, "Type", true));
            this.typeTextBox.Location = new System.Drawing.Point(413, 134);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(100, 20);
            this.typeTextBox.TabIndex = 8;
            // 
            // speedLabel
            // 
            speedLabel.AutoSize = true;
            speedLabel.Location = new System.Drawing.Point(37, 144);
            speedLabel.Name = "speedLabel";
            speedLabel.Size = new System.Drawing.Size(41, 13);
            speedLabel.TabIndex = 9;
            speedLabel.Text = "Speed:";
            // 
            // speedTextBox
            // 
            this.speedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.processorBindingSource, "Speed", true));
            this.speedTextBox.Location = new System.Drawing.Point(145, 137);
            this.speedTextBox.Name = "speedTextBox";
            this.speedTextBox.Size = new System.Drawing.Size(100, 20);
            this.speedTextBox.TabIndex = 10;
            // 
            // purchaseDateLabel
            // 
            purchaseDateLabel.AutoSize = true;
            purchaseDateLabel.Location = new System.Drawing.Point(37, 232);
            purchaseDateLabel.Name = "purchaseDateLabel";
            purchaseDateLabel.Size = new System.Drawing.Size(81, 13);
            purchaseDateLabel.TabIndex = 11;
            purchaseDateLabel.Text = "Purchase Date:";
            // 
            // purchaseDateDateTimePicker
            // 
            this.purchaseDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.processorBindingSource, "PurchaseDate", true));
            this.purchaseDateDateTimePicker.Location = new System.Drawing.Point(145, 225);
            this.purchaseDateDateTimePicker.Name = "purchaseDateDateTimePicker";
            this.purchaseDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.purchaseDateDateTimePicker.TabIndex = 12;
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new System.Drawing.Point(37, 178);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(49, 13);
            quantityLabel.TabIndex = 13;
            quantityLabel.Text = "Quantity:";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.processorBindingSource, "Quantity", true));
            this.quantityTextBox.Location = new System.Drawing.Point(145, 178);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantityTextBox.TabIndex = 14;
            // 
            // unitPriceLabel
            // 
            unitPriceLabel.AutoSize = true;
            unitPriceLabel.Location = new System.Drawing.Point(342, 101);
            unitPriceLabel.Name = "unitPriceLabel";
            unitPriceLabel.Size = new System.Drawing.Size(56, 13);
            unitPriceLabel.TabIndex = 15;
            unitPriceLabel.Text = "Unit Price:";
            // 
            // unitPriceTextBox
            // 
            this.unitPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.processorBindingSource, "UnitPrice", true));
            this.unitPriceTextBox.Location = new System.Drawing.Point(412, 101);
            this.unitPriceTextBox.Name = "unitPriceTextBox";
            this.unitPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.unitPriceTextBox.TabIndex = 16;
            // 
            // BackBtn
            // 
            this.BackBtn.AutoSize = true;
            this.BackBtn.Location = new System.Drawing.Point(629, 13);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(32, 13);
            this.BackBtn.TabIndex = 17;
            this.BackBtn.Text = "Back";
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // ProcessorAddInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 301);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(unitPriceLabel);
            this.Controls.Add(this.unitPriceTextBox);
            this.Controls.Add(quantityLabel);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(purchaseDateLabel);
            this.Controls.Add(this.purchaseDateDateTimePicker);
            this.Controls.Add(speedLabel);
            this.Controls.Add(this.speedTextBox);
            this.Controls.Add(typeLabel);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(numberOfPortsLabel);
            this.Controls.Add(this.numberOfPortsTextBox);
            this.Controls.Add(cacheSizeLabel);
            this.Controls.Add(this.cacheSizeTextBox);
            this.Controls.Add(modelNumberLabel);
            this.Controls.Add(this.modelNumberTextBox);
            this.Controls.Add(this.processorBindingNavigator);
            this.Name = "ProcessorAddInventory";
            this.Text = "ProcessorAddInventory";
            this.Load += new System.EventHandler(this.ProcessorAddInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcpProfessionalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processorBindingNavigator)).EndInit();
            this.processorBindingNavigator.ResumeLayout(false);
            this.processorBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PcpProfessionalDataSet pcpProfessionalDataSet;
        private System.Windows.Forms.BindingSource processorBindingSource;
        private PcpProfessionalDataSetTableAdapters.ProcessorTableAdapter processorTableAdapter;
        private PcpProfessionalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator processorBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton processorBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox modelNumberTextBox;
        private System.Windows.Forms.TextBox cacheSizeTextBox;
        private System.Windows.Forms.TextBox numberOfPortsTextBox;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.TextBox speedTextBox;
        private System.Windows.Forms.DateTimePicker purchaseDateDateTimePicker;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox unitPriceTextBox;
        private System.Windows.Forms.Label BackBtn;
    }
}