
namespace PcpProfessionals
{
    partial class HardDiskAddInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HardDiskAddInventory));
            System.Windows.Forms.Label partNumberLabel;
            System.Windows.Forms.Label capacityLabel;
            System.Windows.Forms.Label rPMLabel;
            System.Windows.Forms.Label sizeLabel;
            System.Windows.Forms.Label brandLabel;
            System.Windows.Forms.Label typeLabel;
            System.Windows.Forms.Label purchaseDateLabel;
            this.pcpProfessionalDataSet = new PcpProfessionals.PcpProfessionalDataSet();
            this.harddiskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.harddiskTableAdapter = new PcpProfessionals.PcpProfessionalDataSetTableAdapters.HarddiskTableAdapter();
            this.tableAdapterManager = new PcpProfessionals.PcpProfessionalDataSetTableAdapters.TableAdapterManager();
            this.harddiskBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.harddiskBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.partNumberTextBox = new System.Windows.Forms.TextBox();
            this.capacityTextBox = new System.Windows.Forms.TextBox();
            this.rPMTextBox = new System.Windows.Forms.TextBox();
            this.sizeTextBox = new System.Windows.Forms.TextBox();
            this.brandTextBox = new System.Windows.Forms.TextBox();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.purchaseDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            partNumberLabel = new System.Windows.Forms.Label();
            capacityLabel = new System.Windows.Forms.Label();
            rPMLabel = new System.Windows.Forms.Label();
            sizeLabel = new System.Windows.Forms.Label();
            brandLabel = new System.Windows.Forms.Label();
            typeLabel = new System.Windows.Forms.Label();
            purchaseDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcpProfessionalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.harddiskBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.harddiskBindingNavigator)).BeginInit();
            this.harddiskBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcpProfessionalDataSet
            // 
            this.pcpProfessionalDataSet.DataSetName = "PcpProfessionalDataSet";
            this.pcpProfessionalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // harddiskBindingSource
            // 
            this.harddiskBindingSource.DataMember = "Harddisk";
            this.harddiskBindingSource.DataSource = this.pcpProfessionalDataSet;
            // 
            // harddiskTableAdapter
            // 
            this.harddiskTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackPlaneTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BrandTableAdapter = null;
            this.tableAdapterManager.EthernetCardTableAdapter = null;
            this.tableAdapterManager.FiberCardTableAdapter = null;
            this.tableAdapterManager.HarddiskTableAdapter = this.harddiskTableAdapter;
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
            // harddiskBindingNavigator
            // 
            this.harddiskBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.harddiskBindingNavigator.BindingSource = this.harddiskBindingSource;
            this.harddiskBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.harddiskBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.harddiskBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.harddiskBindingNavigatorSaveItem});
            this.harddiskBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.harddiskBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.harddiskBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.harddiskBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.harddiskBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.harddiskBindingNavigator.Name = "harddiskBindingNavigator";
            this.harddiskBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.harddiskBindingNavigator.Size = new System.Drawing.Size(662, 25);
            this.harddiskBindingNavigator.TabIndex = 0;
            this.harddiskBindingNavigator.Text = "bindingNavigator1";
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
            // harddiskBindingNavigatorSaveItem
            // 
            this.harddiskBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.harddiskBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("harddiskBindingNavigatorSaveItem.Image")));
            this.harddiskBindingNavigatorSaveItem.Name = "harddiskBindingNavigatorSaveItem";
            this.harddiskBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.harddiskBindingNavigatorSaveItem.Text = "Save Data";
            this.harddiskBindingNavigatorSaveItem.Click += new System.EventHandler(this.harddiskBindingNavigatorSaveItem_Click);
            // 
            // partNumberLabel
            // 
            partNumberLabel.AutoSize = true;
            partNumberLabel.Location = new System.Drawing.Point(30, 48);
            partNumberLabel.Name = "partNumberLabel";
            partNumberLabel.Size = new System.Drawing.Size(69, 13);
            partNumberLabel.TabIndex = 1;
            partNumberLabel.Text = "Part Number:";
            // 
            // partNumberTextBox
            // 
            this.partNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.harddiskBindingSource, "PartNumber", true));
            this.partNumberTextBox.Location = new System.Drawing.Point(105, 45);
            this.partNumberTextBox.Name = "partNumberTextBox";
            this.partNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.partNumberTextBox.TabIndex = 2;
            // 
            // capacityLabel
            // 
            capacityLabel.AutoSize = true;
            capacityLabel.Location = new System.Drawing.Point(30, 89);
            capacityLabel.Name = "capacityLabel";
            capacityLabel.Size = new System.Drawing.Size(51, 13);
            capacityLabel.TabIndex = 3;
            capacityLabel.Text = "Capacity:";
            // 
            // capacityTextBox
            // 
            this.capacityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.harddiskBindingSource, "Capacity", true));
            this.capacityTextBox.Location = new System.Drawing.Point(105, 86);
            this.capacityTextBox.Name = "capacityTextBox";
            this.capacityTextBox.Size = new System.Drawing.Size(100, 20);
            this.capacityTextBox.TabIndex = 4;
            // 
            // rPMLabel
            // 
            rPMLabel.AutoSize = true;
            rPMLabel.Location = new System.Drawing.Point(30, 139);
            rPMLabel.Name = "rPMLabel";
            rPMLabel.Size = new System.Drawing.Size(34, 13);
            rPMLabel.TabIndex = 5;
            rPMLabel.Text = "RPM:";
            // 
            // rPMTextBox
            // 
            this.rPMTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.harddiskBindingSource, "RPM", true));
            this.rPMTextBox.Location = new System.Drawing.Point(105, 136);
            this.rPMTextBox.Name = "rPMTextBox";
            this.rPMTextBox.Size = new System.Drawing.Size(100, 20);
            this.rPMTextBox.TabIndex = 6;
            // 
            // sizeLabel
            // 
            sizeLabel.AutoSize = true;
            sizeLabel.Location = new System.Drawing.Point(291, 136);
            sizeLabel.Name = "sizeLabel";
            sizeLabel.Size = new System.Drawing.Size(30, 13);
            sizeLabel.TabIndex = 7;
            sizeLabel.Text = "Size:";
            // 
            // sizeTextBox
            // 
            this.sizeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.harddiskBindingSource, "Size", true));
            this.sizeTextBox.Location = new System.Drawing.Point(335, 132);
            this.sizeTextBox.Name = "sizeTextBox";
            this.sizeTextBox.Size = new System.Drawing.Size(100, 20);
            this.sizeTextBox.TabIndex = 8;
            // 
            // brandLabel
            // 
            brandLabel.AutoSize = true;
            brandLabel.Location = new System.Drawing.Point(291, 45);
            brandLabel.Name = "brandLabel";
            brandLabel.Size = new System.Drawing.Size(38, 13);
            brandLabel.TabIndex = 9;
            brandLabel.Text = "Brand:";
            // 
            // brandTextBox
            // 
            this.brandTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.harddiskBindingSource, "Brand", true));
            this.brandTextBox.Location = new System.Drawing.Point(335, 42);
            this.brandTextBox.Name = "brandTextBox";
            this.brandTextBox.Size = new System.Drawing.Size(100, 20);
            this.brandTextBox.TabIndex = 10;
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new System.Drawing.Point(291, 89);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(34, 13);
            typeLabel.TabIndex = 11;
            typeLabel.Text = "Type:";
            // 
            // typeTextBox
            // 
            this.typeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.harddiskBindingSource, "Type", true));
            this.typeTextBox.Location = new System.Drawing.Point(335, 82);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(100, 20);
            this.typeTextBox.TabIndex = 12;
            // 
            // purchaseDateLabel
            // 
            purchaseDateLabel.AutoSize = true;
            purchaseDateLabel.Location = new System.Drawing.Point(30, 214);
            purchaseDateLabel.Name = "purchaseDateLabel";
            purchaseDateLabel.Size = new System.Drawing.Size(81, 13);
            purchaseDateLabel.TabIndex = 13;
            purchaseDateLabel.Text = "Purchase Date:";
            // 
            // purchaseDateDateTimePicker
            // 
            this.purchaseDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.harddiskBindingSource, "PurchaseDate", true));
            this.purchaseDateDateTimePicker.Location = new System.Drawing.Point(117, 208);
            this.purchaseDateDateTimePicker.Name = "purchaseDateDateTimePicker";
            this.purchaseDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.purchaseDateDateTimePicker.TabIndex = 14;
            // 
            // HardDiskAddInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 289);
            this.Controls.Add(purchaseDateLabel);
            this.Controls.Add(this.purchaseDateDateTimePicker);
            this.Controls.Add(typeLabel);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(brandLabel);
            this.Controls.Add(this.brandTextBox);
            this.Controls.Add(sizeLabel);
            this.Controls.Add(this.sizeTextBox);
            this.Controls.Add(rPMLabel);
            this.Controls.Add(this.rPMTextBox);
            this.Controls.Add(capacityLabel);
            this.Controls.Add(this.capacityTextBox);
            this.Controls.Add(partNumberLabel);
            this.Controls.Add(this.partNumberTextBox);
            this.Controls.Add(this.harddiskBindingNavigator);
            this.Name = "HardDiskAddInventory";
            this.Text = "HardDiskAddInventory";
            this.Load += new System.EventHandler(this.HardDiskAddInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcpProfessionalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.harddiskBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.harddiskBindingNavigator)).EndInit();
            this.harddiskBindingNavigator.ResumeLayout(false);
            this.harddiskBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PcpProfessionalDataSet pcpProfessionalDataSet;
        private System.Windows.Forms.BindingSource harddiskBindingSource;
        private PcpProfessionalDataSetTableAdapters.HarddiskTableAdapter harddiskTableAdapter;
        private PcpProfessionalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator harddiskBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton harddiskBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox partNumberTextBox;
        private System.Windows.Forms.TextBox capacityTextBox;
        private System.Windows.Forms.TextBox rPMTextBox;
        private System.Windows.Forms.TextBox sizeTextBox;
        private System.Windows.Forms.TextBox brandTextBox;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.DateTimePicker purchaseDateDateTimePicker;
    }
}