
namespace PcpProfessionals
{
    partial class EthernetCardAddInventory
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
            System.Windows.Forms.Label typeLabel;
            System.Windows.Forms.Label numberOfPortsLabel;
            System.Windows.Forms.Label speedLabel;
            System.Windows.Forms.Label slotTypeLabel;
            System.Windows.Forms.Label purchaseDateLabel;
            System.Windows.Forms.Label quantityLabel;
            System.Windows.Forms.Label unitPriceLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EthernetCardAddInventory));
            this.pcpProfessionalDataSet = new PcpProfessionals.PcpProfessionalDataSet();
            this.ethernetCardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ethernetCardTableAdapter = new PcpProfessionals.PcpProfessionalDataSetTableAdapters.EthernetCardTableAdapter();
            this.tableAdapterManager = new PcpProfessionals.PcpProfessionalDataSetTableAdapters.TableAdapterManager();
            this.ethernetCardBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.ethernetCardBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.numberOfPortsTextBox = new System.Windows.Forms.TextBox();
            this.speedTextBox = new System.Windows.Forms.TextBox();
            this.slotTypeTextBox = new System.Windows.Forms.TextBox();
            this.purchaseDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.unitPriceTextBox = new System.Windows.Forms.TextBox();
            this.BackBtn = new System.Windows.Forms.Label();
            this.ComponentLbl = new System.Windows.Forms.Label();
            typeLabel = new System.Windows.Forms.Label();
            numberOfPortsLabel = new System.Windows.Forms.Label();
            speedLabel = new System.Windows.Forms.Label();
            slotTypeLabel = new System.Windows.Forms.Label();
            purchaseDateLabel = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            unitPriceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcpProfessionalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ethernetCardBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ethernetCardBindingNavigator)).BeginInit();
            this.ethernetCardBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            typeLabel.Location = new System.Drawing.Point(13, 75);
            typeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(44, 18);
            typeLabel.TabIndex = 1;
            typeLabel.Text = "Type:";
            // 
            // numberOfPortsLabel
            // 
            numberOfPortsLabel.AutoSize = true;
            numberOfPortsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numberOfPortsLabel.Location = new System.Drawing.Point(13, 132);
            numberOfPortsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            numberOfPortsLabel.Name = "numberOfPortsLabel";
            numberOfPortsLabel.Size = new System.Drawing.Size(125, 18);
            numberOfPortsLabel.TabIndex = 3;
            numberOfPortsLabel.Text = "Number Of Ports:";
            // 
            // speedLabel
            // 
            speedLabel.AutoSize = true;
            speedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            speedLabel.Location = new System.Drawing.Point(13, 193);
            speedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            speedLabel.Name = "speedLabel";
            speedLabel.Size = new System.Drawing.Size(54, 18);
            speedLabel.TabIndex = 5;
            speedLabel.Text = "Speed:";
            // 
            // slotTypeLabel
            // 
            slotTypeLabel.AutoSize = true;
            slotTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            slotTypeLabel.Location = new System.Drawing.Point(13, 252);
            slotTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            slotTypeLabel.Name = "slotTypeLabel";
            slotTypeLabel.Size = new System.Drawing.Size(74, 18);
            slotTypeLabel.TabIndex = 7;
            slotTypeLabel.Text = "Slot Type:";
            // 
            // purchaseDateLabel
            // 
            purchaseDateLabel.AutoSize = true;
            purchaseDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            purchaseDateLabel.Location = new System.Drawing.Point(13, 324);
            purchaseDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            purchaseDateLabel.Name = "purchaseDateLabel";
            purchaseDateLabel.Size = new System.Drawing.Size(110, 18);
            purchaseDateLabel.TabIndex = 9;
            purchaseDateLabel.Text = "Purchase Date:";
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            quantityLabel.Location = new System.Drawing.Point(504, 75);
            quantityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(66, 18);
            quantityLabel.TabIndex = 11;
            quantityLabel.Text = "Quantity:";
            // 
            // unitPriceLabel
            // 
            unitPriceLabel.AutoSize = true;
            unitPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            unitPriceLabel.Location = new System.Drawing.Point(504, 132);
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
            // ethernetCardBindingSource
            // 
            this.ethernetCardBindingSource.DataMember = "EthernetCard";
            this.ethernetCardBindingSource.DataSource = this.pcpProfessionalDataSet;
            // 
            // ethernetCardTableAdapter
            // 
            this.ethernetCardTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackPlaneTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BrandTableAdapter = null;
            this.tableAdapterManager.EthernetCardTableAdapter = this.ethernetCardTableAdapter;
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
            // ethernetCardBindingNavigator
            // 
            this.ethernetCardBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.ethernetCardBindingNavigator.BindingSource = this.ethernetCardBindingSource;
            this.ethernetCardBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ethernetCardBindingNavigator.DeleteItem = null;
            this.ethernetCardBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.ethernetCardBindingNavigatorSaveItem});
            this.ethernetCardBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.ethernetCardBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ethernetCardBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ethernetCardBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ethernetCardBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ethernetCardBindingNavigator.Name = "ethernetCardBindingNavigator";
            this.ethernetCardBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.ethernetCardBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ethernetCardBindingNavigator.Size = new System.Drawing.Size(994, 25);
            this.ethernetCardBindingNavigator.TabIndex = 0;
            this.ethernetCardBindingNavigator.Text = "bindingNavigator1";
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
            // ethernetCardBindingNavigatorSaveItem
            // 
            this.ethernetCardBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ethernetCardBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("ethernetCardBindingNavigatorSaveItem.Image")));
            this.ethernetCardBindingNavigatorSaveItem.Name = "ethernetCardBindingNavigatorSaveItem";
            this.ethernetCardBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.ethernetCardBindingNavigatorSaveItem.Text = "Save Data";
            this.ethernetCardBindingNavigatorSaveItem.Click += new System.EventHandler(this.ethernetCardBindingNavigatorSaveItem_Click);
            // 
            // typeTextBox
            // 
            this.typeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ethernetCardBindingSource, "Type", true));
            this.typeTextBox.Location = new System.Drawing.Point(232, 72);
            this.typeTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(148, 24);
            this.typeTextBox.TabIndex = 2;
            // 
            // numberOfPortsTextBox
            // 
            this.numberOfPortsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ethernetCardBindingSource, "NumberOfPorts", true));
            this.numberOfPortsTextBox.Location = new System.Drawing.Point(232, 129);
            this.numberOfPortsTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numberOfPortsTextBox.Name = "numberOfPortsTextBox";
            this.numberOfPortsTextBox.Size = new System.Drawing.Size(148, 24);
            this.numberOfPortsTextBox.TabIndex = 4;
            // 
            // speedTextBox
            // 
            this.speedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ethernetCardBindingSource, "Speed", true));
            this.speedTextBox.Location = new System.Drawing.Point(232, 190);
            this.speedTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.speedTextBox.Name = "speedTextBox";
            this.speedTextBox.Size = new System.Drawing.Size(148, 24);
            this.speedTextBox.TabIndex = 6;
            // 
            // slotTypeTextBox
            // 
            this.slotTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ethernetCardBindingSource, "SlotType", true));
            this.slotTypeTextBox.Location = new System.Drawing.Point(232, 249);
            this.slotTypeTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.slotTypeTextBox.Name = "slotTypeTextBox";
            this.slotTypeTextBox.Size = new System.Drawing.Size(148, 24);
            this.slotTypeTextBox.TabIndex = 8;
            // 
            // purchaseDateDateTimePicker
            // 
            this.purchaseDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ethernetCardBindingSource, "PurchaseDate", true));
            this.purchaseDateDateTimePicker.Location = new System.Drawing.Point(232, 319);
            this.purchaseDateDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.purchaseDateDateTimePicker.Name = "purchaseDateDateTimePicker";
            this.purchaseDateDateTimePicker.Size = new System.Drawing.Size(298, 24);
            this.purchaseDateDateTimePicker.TabIndex = 10;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ethernetCardBindingSource, "Quantity", true));
            this.quantityTextBox.Location = new System.Drawing.Point(628, 72);
            this.quantityTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(148, 24);
            this.quantityTextBox.TabIndex = 12;
            // 
            // unitPriceTextBox
            // 
            this.unitPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ethernetCardBindingSource, "UnitPrice", true));
            this.unitPriceTextBox.Location = new System.Drawing.Point(628, 129);
            this.unitPriceTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.unitPriceTextBox.Name = "unitPriceTextBox";
            this.unitPriceTextBox.Size = new System.Drawing.Size(148, 24);
            this.unitPriceTextBox.TabIndex = 14;
            // 
            // BackBtn
            // 
            this.BackBtn.AutoSize = true;
            this.BackBtn.Location = new System.Drawing.Point(924, 18);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(42, 18);
            this.BackBtn.TabIndex = 15;
            this.BackBtn.Text = "Back";
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // ComponentLbl
            // 
            this.ComponentLbl.AutoSize = true;
            this.ComponentLbl.Location = new System.Drawing.Point(441, 18);
            this.ComponentLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ComponentLbl.Name = "ComponentLbl";
            this.ComponentLbl.Size = new System.Drawing.Size(46, 18);
            this.ComponentLbl.TabIndex = 16;
            this.ComponentLbl.Text = "label1";
            this.ComponentLbl.Click += new System.EventHandler(this.ComponentLbl_Click);
            // 
            // EthernetCardAddInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 464);
            this.Controls.Add(this.ComponentLbl);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(unitPriceLabel);
            this.Controls.Add(this.unitPriceTextBox);
            this.Controls.Add(quantityLabel);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(purchaseDateLabel);
            this.Controls.Add(this.purchaseDateDateTimePicker);
            this.Controls.Add(slotTypeLabel);
            this.Controls.Add(this.slotTypeTextBox);
            this.Controls.Add(speedLabel);
            this.Controls.Add(this.speedTextBox);
            this.Controls.Add(numberOfPortsLabel);
            this.Controls.Add(this.numberOfPortsTextBox);
            this.Controls.Add(typeLabel);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(this.ethernetCardBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EthernetCardAddInventory";
            this.Text = "EthernetCardAddInventory";
            this.Load += new System.EventHandler(this.EthernetCardAddInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcpProfessionalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ethernetCardBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ethernetCardBindingNavigator)).EndInit();
            this.ethernetCardBindingNavigator.ResumeLayout(false);
            this.ethernetCardBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PcpProfessionalDataSet pcpProfessionalDataSet;
        private System.Windows.Forms.BindingSource ethernetCardBindingSource;
        private PcpProfessionalDataSetTableAdapters.EthernetCardTableAdapter ethernetCardTableAdapter;
        private PcpProfessionalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator ethernetCardBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton ethernetCardBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.TextBox numberOfPortsTextBox;
        private System.Windows.Forms.TextBox speedTextBox;
        private System.Windows.Forms.TextBox slotTypeTextBox;
        private System.Windows.Forms.DateTimePicker purchaseDateDateTimePicker;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox unitPriceTextBox;
        private System.Windows.Forms.Label BackBtn;
        private System.Windows.Forms.Label ComponentLbl;
    }
}