
namespace PcpProfessionals
{
    partial class MemoryAddInventory
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
            System.Windows.Forms.Label rankLabel;
            System.Windows.Forms.Label ddrLabel;
            System.Windows.Forms.Label brandLabel;
            System.Windows.Forms.Label purchaseDateLabel;
            System.Windows.Forms.Label quantityLabel;
            System.Windows.Forms.Label unitPriceLabel;
            System.Windows.Forms.Label heatSinkLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemoryAddInventory));
            this.pcpProfessionalDataSet = new PcpProfessionals.PcpProfessionalDataSet();
            this.memoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memoryTableAdapter = new PcpProfessionals.PcpProfessionalDataSetTableAdapters.MemoryTableAdapter();
            this.tableAdapterManager = new PcpProfessionals.PcpProfessionalDataSetTableAdapters.TableAdapterManager();
            this.memoryBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.memoryBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.sizeTextBox = new System.Windows.Forms.TextBox();
            this.rankTextBox = new System.Windows.Forms.TextBox();
            this.ddrTextBox = new System.Windows.Forms.TextBox();
            this.brandTextBox = new System.Windows.Forms.TextBox();
            this.purchaseDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.unitPriceTextBox = new System.Windows.Forms.TextBox();
            this.heatSinkCheckBox = new System.Windows.Forms.CheckBox();
            this.BackBtn = new System.Windows.Forms.Label();
            sizeLabel = new System.Windows.Forms.Label();
            rankLabel = new System.Windows.Forms.Label();
            ddrLabel = new System.Windows.Forms.Label();
            brandLabel = new System.Windows.Forms.Label();
            purchaseDateLabel = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            unitPriceLabel = new System.Windows.Forms.Label();
            heatSinkLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcpProfessionalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoryBindingNavigator)).BeginInit();
            this.memoryBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // sizeLabel
            // 
            sizeLabel.AutoSize = true;
            sizeLabel.Location = new System.Drawing.Point(37, 54);
            sizeLabel.Name = "sizeLabel";
            sizeLabel.Size = new System.Drawing.Size(30, 13);
            sizeLabel.TabIndex = 1;
            sizeLabel.Text = "Size:";
            // 
            // rankLabel
            // 
            rankLabel.AutoSize = true;
            rankLabel.Location = new System.Drawing.Point(38, 105);
            rankLabel.Name = "rankLabel";
            rankLabel.Size = new System.Drawing.Size(36, 13);
            rankLabel.TabIndex = 3;
            rankLabel.Text = "Rank:";
            // 
            // ddrLabel
            // 
            ddrLabel.AutoSize = true;
            ddrLabel.Location = new System.Drawing.Point(40, 157);
            ddrLabel.Name = "ddrLabel";
            ddrLabel.Size = new System.Drawing.Size(27, 13);
            ddrLabel.TabIndex = 5;
            ddrLabel.Text = "Ddr:";
            // 
            // brandLabel
            // 
            brandLabel.AutoSize = true;
            brandLabel.Location = new System.Drawing.Point(326, 54);
            brandLabel.Name = "brandLabel";
            brandLabel.Size = new System.Drawing.Size(38, 13);
            brandLabel.TabIndex = 7;
            brandLabel.Text = "Brand:";
            // 
            // purchaseDateLabel
            // 
            purchaseDateLabel.AutoSize = true;
            purchaseDateLabel.Location = new System.Drawing.Point(40, 220);
            purchaseDateLabel.Name = "purchaseDateLabel";
            purchaseDateLabel.Size = new System.Drawing.Size(81, 13);
            purchaseDateLabel.TabIndex = 9;
            purchaseDateLabel.Text = "Purchase Date:";
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new System.Drawing.Point(326, 105);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(49, 13);
            quantityLabel.TabIndex = 11;
            quantityLabel.Text = "Quantity:";
            // 
            // unitPriceLabel
            // 
            unitPriceLabel.AutoSize = true;
            unitPriceLabel.Location = new System.Drawing.Point(326, 157);
            unitPriceLabel.Name = "unitPriceLabel";
            unitPriceLabel.Size = new System.Drawing.Size(56, 13);
            unitPriceLabel.TabIndex = 13;
            unitPriceLabel.Text = "Unit Price:";
            // 
            // heatSinkLabel
            // 
            heatSinkLabel.AutoSize = true;
            heatSinkLabel.Location = new System.Drawing.Point(379, 220);
            heatSinkLabel.Name = "heatSinkLabel";
            heatSinkLabel.Size = new System.Drawing.Size(57, 13);
            heatSinkLabel.TabIndex = 15;
            heatSinkLabel.Text = "Heat Sink:";
            // 
            // pcpProfessionalDataSet
            // 
            this.pcpProfessionalDataSet.DataSetName = "PcpProfessionalDataSet";
            this.pcpProfessionalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // memoryBindingSource
            // 
            this.memoryBindingSource.DataMember = "Memory";
            this.memoryBindingSource.DataSource = this.pcpProfessionalDataSet;
            // 
            // memoryTableAdapter
            // 
            this.memoryTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.MemoryTableAdapter = this.memoryTableAdapter;
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
            // memoryBindingNavigator
            // 
            this.memoryBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.memoryBindingNavigator.BindingSource = this.memoryBindingSource;
            this.memoryBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.memoryBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.memoryBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.memoryBindingNavigatorSaveItem});
            this.memoryBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.memoryBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.memoryBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.memoryBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.memoryBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.memoryBindingNavigator.Name = "memoryBindingNavigator";
            this.memoryBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.memoryBindingNavigator.Size = new System.Drawing.Size(682, 25);
            this.memoryBindingNavigator.TabIndex = 0;
            this.memoryBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
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
            // memoryBindingNavigatorSaveItem
            // 
            this.memoryBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.memoryBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("memoryBindingNavigatorSaveItem.Image")));
            this.memoryBindingNavigatorSaveItem.Name = "memoryBindingNavigatorSaveItem";
            this.memoryBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.memoryBindingNavigatorSaveItem.Text = "Save Data";
            this.memoryBindingNavigatorSaveItem.Click += new System.EventHandler(this.memoryBindingNavigatorSaveItem_Click);
            // 
            // sizeTextBox
            // 
            this.sizeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memoryBindingSource, "Size", true));
            this.sizeTextBox.Location = new System.Drawing.Point(102, 51);
            this.sizeTextBox.Name = "sizeTextBox";
            this.sizeTextBox.Size = new System.Drawing.Size(100, 20);
            this.sizeTextBox.TabIndex = 2;
            // 
            // rankTextBox
            // 
            this.rankTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memoryBindingSource, "Rank", true));
            this.rankTextBox.Location = new System.Drawing.Point(102, 102);
            this.rankTextBox.Name = "rankTextBox";
            this.rankTextBox.Size = new System.Drawing.Size(100, 20);
            this.rankTextBox.TabIndex = 4;
            this.rankTextBox.TextChanged += new System.EventHandler(this.rankTextBox_TextChanged);
            // 
            // ddrTextBox
            // 
            this.ddrTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memoryBindingSource, "Ddr", true));
            this.ddrTextBox.Location = new System.Drawing.Point(102, 150);
            this.ddrTextBox.Name = "ddrTextBox";
            this.ddrTextBox.Size = new System.Drawing.Size(100, 20);
            this.ddrTextBox.TabIndex = 6;
            // 
            // brandTextBox
            // 
            this.brandTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memoryBindingSource, "Brand", true));
            this.brandTextBox.Location = new System.Drawing.Point(392, 47);
            this.brandTextBox.Name = "brandTextBox";
            this.brandTextBox.Size = new System.Drawing.Size(100, 20);
            this.brandTextBox.TabIndex = 8;
            // 
            // purchaseDateDateTimePicker
            // 
            this.purchaseDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.memoryBindingSource, "PurchaseDate", true));
            this.purchaseDateDateTimePicker.Location = new System.Drawing.Point(127, 214);
            this.purchaseDateDateTimePicker.Name = "purchaseDateDateTimePicker";
            this.purchaseDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.purchaseDateDateTimePicker.TabIndex = 10;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memoryBindingSource, "Quantity", true));
            this.quantityTextBox.Location = new System.Drawing.Point(392, 102);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantityTextBox.TabIndex = 12;
            // 
            // unitPriceTextBox
            // 
            this.unitPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memoryBindingSource, "UnitPrice", true));
            this.unitPriceTextBox.Location = new System.Drawing.Point(392, 154);
            this.unitPriceTextBox.Name = "unitPriceTextBox";
            this.unitPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.unitPriceTextBox.TabIndex = 14;
            // 
            // heatSinkCheckBox
            // 
            this.heatSinkCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.memoryBindingSource, "HeatSink", true));
            this.heatSinkCheckBox.Location = new System.Drawing.Point(442, 215);
            this.heatSinkCheckBox.Name = "heatSinkCheckBox";
            this.heatSinkCheckBox.Size = new System.Drawing.Size(104, 24);
            this.heatSinkCheckBox.TabIndex = 16;
            this.heatSinkCheckBox.Text = "Available";
            this.heatSinkCheckBox.UseVisualStyleBackColor = true;
            // 
            // BackBtn
            // 
            this.BackBtn.AutoSize = true;
            this.BackBtn.Location = new System.Drawing.Point(635, 13);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(32, 13);
            this.BackBtn.TabIndex = 17;
            this.BackBtn.Text = "Back";
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // MemoryAddInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 350);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(heatSinkLabel);
            this.Controls.Add(this.heatSinkCheckBox);
            this.Controls.Add(unitPriceLabel);
            this.Controls.Add(this.unitPriceTextBox);
            this.Controls.Add(quantityLabel);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(purchaseDateLabel);
            this.Controls.Add(this.purchaseDateDateTimePicker);
            this.Controls.Add(brandLabel);
            this.Controls.Add(this.brandTextBox);
            this.Controls.Add(ddrLabel);
            this.Controls.Add(this.ddrTextBox);
            this.Controls.Add(rankLabel);
            this.Controls.Add(this.rankTextBox);
            this.Controls.Add(sizeLabel);
            this.Controls.Add(this.sizeTextBox);
            this.Controls.Add(this.memoryBindingNavigator);
            this.Name = "MemoryAddInventory";
            this.Text = "MemoryAddInventory";
            this.Load += new System.EventHandler(this.MemoryAddInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcpProfessionalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoryBindingNavigator)).EndInit();
            this.memoryBindingNavigator.ResumeLayout(false);
            this.memoryBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PcpProfessionalDataSet pcpProfessionalDataSet;
        private System.Windows.Forms.BindingSource memoryBindingSource;
        private PcpProfessionalDataSetTableAdapters.MemoryTableAdapter memoryTableAdapter;
        private PcpProfessionalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator memoryBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton memoryBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox sizeTextBox;
        private System.Windows.Forms.TextBox rankTextBox;
        private System.Windows.Forms.TextBox ddrTextBox;
        private System.Windows.Forms.TextBox brandTextBox;
        private System.Windows.Forms.DateTimePicker purchaseDateDateTimePicker;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox unitPriceTextBox;
        private System.Windows.Forms.CheckBox heatSinkCheckBox;
        private System.Windows.Forms.Label BackBtn;
    }
}