
namespace PcpProfessionals
{
    partial class HddCaddyAddInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HddCaddyAddInventory));
            System.Windows.Forms.Label sizeLabel;
            System.Windows.Forms.Label brandLabel;
            System.Windows.Forms.Label purchaseDateLabel;
            this.pcpProfessionalDataSet = new PcpProfessionals.PcpProfessionalDataSet();
            this.hddCadyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hddCadyTableAdapter = new PcpProfessionals.PcpProfessionalDataSetTableAdapters.HddCadyTableAdapter();
            this.tableAdapterManager = new PcpProfessionals.PcpProfessionalDataSetTableAdapters.TableAdapterManager();
            this.hddCadyBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.hddCadyBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.sizeTextBox = new System.Windows.Forms.TextBox();
            this.brandTextBox = new System.Windows.Forms.TextBox();
            this.purchaseDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            sizeLabel = new System.Windows.Forms.Label();
            brandLabel = new System.Windows.Forms.Label();
            purchaseDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcpProfessionalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hddCadyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hddCadyBindingNavigator)).BeginInit();
            this.hddCadyBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcpProfessionalDataSet
            // 
            this.pcpProfessionalDataSet.DataSetName = "PcpProfessionalDataSet";
            this.pcpProfessionalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hddCadyBindingSource
            // 
            this.hddCadyBindingSource.DataMember = "HddCady";
            this.hddCadyBindingSource.DataSource = this.pcpProfessionalDataSet;
            // 
            // hddCadyTableAdapter
            // 
            this.hddCadyTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackPlaneTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BrandTableAdapter = null;
            this.tableAdapterManager.EthernetCardTableAdapter = null;
            this.tableAdapterManager.FiberCardTableAdapter = null;
            this.tableAdapterManager.HarddiskTableAdapter = null;
            this.tableAdapterManager.HddCadyTableAdapter = this.hddCadyTableAdapter;
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
            // hddCadyBindingNavigator
            // 
            this.hddCadyBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.hddCadyBindingNavigator.BindingSource = this.hddCadyBindingSource;
            this.hddCadyBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.hddCadyBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.hddCadyBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.hddCadyBindingNavigatorSaveItem});
            this.hddCadyBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.hddCadyBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.hddCadyBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.hddCadyBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.hddCadyBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.hddCadyBindingNavigator.Name = "hddCadyBindingNavigator";
            this.hddCadyBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.hddCadyBindingNavigator.Size = new System.Drawing.Size(636, 25);
            this.hddCadyBindingNavigator.TabIndex = 0;
            this.hddCadyBindingNavigator.Text = "bindingNavigator1";
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
            // hddCadyBindingNavigatorSaveItem
            // 
            this.hddCadyBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.hddCadyBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("hddCadyBindingNavigatorSaveItem.Image")));
            this.hddCadyBindingNavigatorSaveItem.Name = "hddCadyBindingNavigatorSaveItem";
            this.hddCadyBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.hddCadyBindingNavigatorSaveItem.Text = "Save Data";
            this.hddCadyBindingNavigatorSaveItem.Click += new System.EventHandler(this.hddCadyBindingNavigatorSaveItem_Click);
            // 
            // sizeLabel
            // 
            sizeLabel.AutoSize = true;
            sizeLabel.Location = new System.Drawing.Point(32, 82);
            sizeLabel.Name = "sizeLabel";
            sizeLabel.Size = new System.Drawing.Size(30, 13);
            sizeLabel.TabIndex = 1;
            sizeLabel.Text = "Size:";
            // 
            // sizeTextBox
            // 
            this.sizeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hddCadyBindingSource, "Size", true));
            this.sizeTextBox.Location = new System.Drawing.Point(119, 79);
            this.sizeTextBox.Name = "sizeTextBox";
            this.sizeTextBox.Size = new System.Drawing.Size(100, 20);
            this.sizeTextBox.TabIndex = 2;
            // 
            // brandLabel
            // 
            brandLabel.AutoSize = true;
            brandLabel.Location = new System.Drawing.Point(32, 135);
            brandLabel.Name = "brandLabel";
            brandLabel.Size = new System.Drawing.Size(38, 13);
            brandLabel.TabIndex = 3;
            brandLabel.Text = "Brand:";
            // 
            // brandTextBox
            // 
            this.brandTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hddCadyBindingSource, "Brand", true));
            this.brandTextBox.Location = new System.Drawing.Point(119, 132);
            this.brandTextBox.Name = "brandTextBox";
            this.brandTextBox.Size = new System.Drawing.Size(100, 20);
            this.brandTextBox.TabIndex = 4;
            // 
            // purchaseDateLabel
            // 
            purchaseDateLabel.AutoSize = true;
            purchaseDateLabel.Location = new System.Drawing.Point(32, 194);
            purchaseDateLabel.Name = "purchaseDateLabel";
            purchaseDateLabel.Size = new System.Drawing.Size(81, 13);
            purchaseDateLabel.TabIndex = 5;
            purchaseDateLabel.Text = "Purchase Date:";
            // 
            // purchaseDateDateTimePicker
            // 
            this.purchaseDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.hddCadyBindingSource, "PurchaseDate", true));
            this.purchaseDateDateTimePicker.Location = new System.Drawing.Point(119, 188);
            this.purchaseDateDateTimePicker.Name = "purchaseDateDateTimePicker";
            this.purchaseDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.purchaseDateDateTimePicker.TabIndex = 6;
            // 
            // HddCaddyAddInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 309);
            this.Controls.Add(purchaseDateLabel);
            this.Controls.Add(this.purchaseDateDateTimePicker);
            this.Controls.Add(brandLabel);
            this.Controls.Add(this.brandTextBox);
            this.Controls.Add(sizeLabel);
            this.Controls.Add(this.sizeTextBox);
            this.Controls.Add(this.hddCadyBindingNavigator);
            this.Name = "HddCaddyAddInventory";
            this.Text = "HddCaddyAddInventory";
            this.Load += new System.EventHandler(this.HddCaddyAddInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcpProfessionalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hddCadyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hddCadyBindingNavigator)).EndInit();
            this.hddCadyBindingNavigator.ResumeLayout(false);
            this.hddCadyBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PcpProfessionalDataSet pcpProfessionalDataSet;
        private System.Windows.Forms.BindingSource hddCadyBindingSource;
        private PcpProfessionalDataSetTableAdapters.HddCadyTableAdapter hddCadyTableAdapter;
        private PcpProfessionalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator hddCadyBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton hddCadyBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox sizeTextBox;
        private System.Windows.Forms.TextBox brandTextBox;
        private System.Windows.Forms.DateTimePicker purchaseDateDateTimePicker;
    }
}