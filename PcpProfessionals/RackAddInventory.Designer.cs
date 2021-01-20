
namespace PcpProfessionals
{
    partial class RackAddInventory
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
            System.Windows.Forms.Label sizeLabel;
            System.Windows.Forms.Label heightLabel;
            System.Windows.Forms.Label widthLabel;
            System.Windows.Forms.Label depthLabel;
            System.Windows.Forms.Label purchaseDateLabel;
            System.Windows.Forms.Label quantityLabel;
            System.Windows.Forms.Label unitPriceLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RackAddInventory));
            this.pcpProfessionalDataSet = new PcpProfessionals.PcpProfessionalDataSet();
            this.rackBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rackTableAdapter = new PcpProfessionals.PcpProfessionalDataSetTableAdapters.RackTableAdapter();
            this.tableAdapterManager = new PcpProfessionals.PcpProfessionalDataSetTableAdapters.TableAdapterManager();
            this.rackBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.rackBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.sizeTextBox = new System.Windows.Forms.TextBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.depthTextBox = new System.Windows.Forms.TextBox();
            this.purchaseDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.unitPriceTextBox = new System.Windows.Forms.TextBox();
            this.BackBtn = new System.Windows.Forms.Label();
            this.ComponentNameLbl = new System.Windows.Forms.Label();
            sizeLabel = new System.Windows.Forms.Label();
            heightLabel = new System.Windows.Forms.Label();
            widthLabel = new System.Windows.Forms.Label();
            depthLabel = new System.Windows.Forms.Label();
            purchaseDateLabel = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            unitPriceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcpProfessionalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rackBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rackBindingNavigator)).BeginInit();
            this.rackBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // sizeLabel
            // 
            sizeLabel.AutoSize = true;
            sizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sizeLabel.Location = new System.Drawing.Point(18, 100);
            sizeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            sizeLabel.Name = "sizeLabel";
            sizeLabel.Size = new System.Drawing.Size(41, 18);
            sizeLabel.TabIndex = 1;
            sizeLabel.Text = "Size:";
            // 
            // heightLabel
            // 
            heightLabel.AutoSize = true;
            heightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            heightLabel.Location = new System.Drawing.Point(18, 169);
            heightLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            heightLabel.Name = "heightLabel";
            heightLabel.Size = new System.Drawing.Size(54, 18);
            heightLabel.TabIndex = 3;
            heightLabel.Text = "Height:";
            // 
            // widthLabel
            // 
            widthLabel.AutoSize = true;
            widthLabel.Location = new System.Drawing.Point(18, 246);
            widthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            widthLabel.Name = "widthLabel";
            widthLabel.Size = new System.Drawing.Size(50, 18);
            widthLabel.TabIndex = 5;
            widthLabel.Text = "Width:";
            // 
            // depthLabel
            // 
            depthLabel.AutoSize = true;
            depthLabel.Location = new System.Drawing.Point(512, 100);
            depthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            depthLabel.Name = "depthLabel";
            depthLabel.Size = new System.Drawing.Size(51, 18);
            depthLabel.TabIndex = 7;
            depthLabel.Text = "Depth:";
            // 
            // purchaseDateLabel
            // 
            purchaseDateLabel.AutoSize = true;
            purchaseDateLabel.Location = new System.Drawing.Point(18, 322);
            purchaseDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            purchaseDateLabel.Name = "purchaseDateLabel";
            purchaseDateLabel.Size = new System.Drawing.Size(110, 18);
            purchaseDateLabel.TabIndex = 9;
            purchaseDateLabel.Text = "Purchase Date:";
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new System.Drawing.Point(512, 175);
            quantityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(66, 18);
            quantityLabel.TabIndex = 11;
            quantityLabel.Text = "Quantity:";
            // 
            // unitPriceLabel
            // 
            unitPriceLabel.AutoSize = true;
            unitPriceLabel.Location = new System.Drawing.Point(512, 249);
            unitPriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            unitPriceLabel.Name = "unitPriceLabel";
            unitPriceLabel.Size = new System.Drawing.Size(76, 18);
            unitPriceLabel.TabIndex = 13;
            unitPriceLabel.Text = "Unit Price:";
            // 
            // pcpProfessionalDataSet
            // 
            this.pcpProfessionalDataSet.DataSetName = "PcpProfessionalDataSet";
            this.pcpProfessionalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rackBindingSource
            // 
            this.rackBindingSource.DataMember = "Rack";
            this.rackBindingSource.DataSource = this.pcpProfessionalDataSet;
            // 
            // rackTableAdapter
            // 
            this.rackTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.ProcessorTableAdapter = null;
            this.tableAdapterManager.RackTableAdapter = this.rackTableAdapter;
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
            // rackBindingNavigator
            // 
            this.rackBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.rackBindingNavigator.BindingSource = this.rackBindingSource;
            this.rackBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.rackBindingNavigator.DeleteItem = null;
            this.rackBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.rackBindingNavigatorSaveItem});
            this.rackBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.rackBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.rackBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.rackBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.rackBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.rackBindingNavigator.Name = "rackBindingNavigator";
            this.rackBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.rackBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.rackBindingNavigator.Size = new System.Drawing.Size(1022, 25);
            this.rackBindingNavigator.TabIndex = 0;
            this.rackBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(73, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // rackBindingNavigatorSaveItem
            // 
            this.rackBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rackBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("rackBindingNavigatorSaveItem.Image")));
            this.rackBindingNavigatorSaveItem.Name = "rackBindingNavigatorSaveItem";
            this.rackBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.rackBindingNavigatorSaveItem.Text = "Save Data";
            this.rackBindingNavigatorSaveItem.Click += new System.EventHandler(this.rackBindingNavigatorSaveItem_Click);
            // 
            // sizeTextBox
            // 
            this.sizeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rackBindingSource, "Size", true));
            this.sizeTextBox.Location = new System.Drawing.Point(147, 101);
            this.sizeTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sizeTextBox.Name = "sizeTextBox";
            this.sizeTextBox.Size = new System.Drawing.Size(148, 24);
            this.sizeTextBox.TabIndex = 2;
            // 
            // heightTextBox
            // 
            this.heightTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rackBindingSource, "Height", true));
            this.heightTextBox.Location = new System.Drawing.Point(147, 169);
            this.heightTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(148, 24);
            this.heightTextBox.TabIndex = 4;
            // 
            // widthTextBox
            // 
            this.widthTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rackBindingSource, "Width", true));
            this.widthTextBox.Location = new System.Drawing.Point(147, 246);
            this.widthTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(148, 24);
            this.widthTextBox.TabIndex = 6;
            // 
            // depthTextBox
            // 
            this.depthTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rackBindingSource, "Depth", true));
            this.depthTextBox.Location = new System.Drawing.Point(639, 100);
            this.depthTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.depthTextBox.Name = "depthTextBox";
            this.depthTextBox.Size = new System.Drawing.Size(148, 24);
            this.depthTextBox.TabIndex = 8;
            // 
            // purchaseDateDateTimePicker
            // 
            this.purchaseDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.rackBindingSource, "PurchaseDate", true));
            this.purchaseDateDateTimePicker.Location = new System.Drawing.Point(177, 322);
            this.purchaseDateDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.purchaseDateDateTimePicker.Name = "purchaseDateDateTimePicker";
            this.purchaseDateDateTimePicker.Size = new System.Drawing.Size(298, 24);
            this.purchaseDateDateTimePicker.TabIndex = 10;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rackBindingSource, "Quantity", true));
            this.quantityTextBox.Location = new System.Drawing.Point(639, 172);
            this.quantityTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(148, 24);
            this.quantityTextBox.TabIndex = 12;
            // 
            // unitPriceTextBox
            // 
            this.unitPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rackBindingSource, "UnitPrice", true));
            this.unitPriceTextBox.Location = new System.Drawing.Point(639, 246);
            this.unitPriceTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.unitPriceTextBox.Name = "unitPriceTextBox";
            this.unitPriceTextBox.Size = new System.Drawing.Size(148, 24);
            this.unitPriceTextBox.TabIndex = 14;
            // 
            // BackBtn
            // 
            this.BackBtn.AutoSize = true;
            this.BackBtn.Location = new System.Drawing.Point(951, 18);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(42, 18);
            this.BackBtn.TabIndex = 15;
            this.BackBtn.Text = "Back";
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // ComponentNameLbl
            // 
            this.ComponentNameLbl.AutoSize = true;
            this.ComponentNameLbl.Location = new System.Drawing.Point(439, 13);
            this.ComponentNameLbl.Name = "ComponentNameLbl";
            this.ComponentNameLbl.Size = new System.Drawing.Size(46, 18);
            this.ComponentNameLbl.TabIndex = 16;
            this.ComponentNameLbl.Text = "label1";
            // 
            // RackAddInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 446);
            this.Controls.Add(this.ComponentNameLbl);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(unitPriceLabel);
            this.Controls.Add(this.unitPriceTextBox);
            this.Controls.Add(quantityLabel);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(purchaseDateLabel);
            this.Controls.Add(this.purchaseDateDateTimePicker);
            this.Controls.Add(depthLabel);
            this.Controls.Add(this.depthTextBox);
            this.Controls.Add(widthLabel);
            this.Controls.Add(this.widthTextBox);
            this.Controls.Add(heightLabel);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(sizeLabel);
            this.Controls.Add(this.sizeTextBox);
            this.Controls.Add(this.rackBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RackAddInventory";
            this.Text = "RackAddInventory";
            this.Load += new System.EventHandler(this.RackAddInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcpProfessionalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rackBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rackBindingNavigator)).EndInit();
            this.rackBindingNavigator.ResumeLayout(false);
            this.rackBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PcpProfessionalDataSet pcpProfessionalDataSet;
        private System.Windows.Forms.BindingSource rackBindingSource;
        private PcpProfessionalDataSetTableAdapters.RackTableAdapter rackTableAdapter;
        private PcpProfessionalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator rackBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton rackBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox sizeTextBox;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.TextBox depthTextBox;
        private System.Windows.Forms.DateTimePicker purchaseDateDateTimePicker;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox unitPriceTextBox;
        private System.Windows.Forms.Label BackBtn;
        private System.Windows.Forms.Label ComponentNameLbl;
    }
}