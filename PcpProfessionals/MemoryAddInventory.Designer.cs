
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
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.unitPriceTextBox = new System.Windows.Forms.TextBox();
            this.heatSinkCheckBox = new System.Windows.Forms.CheckBox();
            this.BackBtn = new System.Windows.Forms.Label();
            this.ComponentNameLbl = new System.Windows.Forms.Label();
            sizeLabel = new System.Windows.Forms.Label();
            rankLabel = new System.Windows.Forms.Label();
            ddrLabel = new System.Windows.Forms.Label();
            brandLabel = new System.Windows.Forms.Label();
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
            sizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sizeLabel.Location = new System.Drawing.Point(13, 76);
            sizeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            sizeLabel.Name = "sizeLabel";
            sizeLabel.Size = new System.Drawing.Size(41, 18);
            sizeLabel.TabIndex = 1;
            sizeLabel.Text = "Size:";
            // 
            // rankLabel
            // 
            rankLabel.AutoSize = true;
            rankLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rankLabel.Location = new System.Drawing.Point(13, 145);
            rankLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            rankLabel.Name = "rankLabel";
            rankLabel.Size = new System.Drawing.Size(47, 18);
            rankLabel.TabIndex = 3;
            rankLabel.Text = "Rank:";
            // 
            // ddrLabel
            // 
            ddrLabel.AutoSize = true;
            ddrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ddrLabel.Location = new System.Drawing.Point(13, 217);
            ddrLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ddrLabel.Name = "ddrLabel";
            ddrLabel.Size = new System.Drawing.Size(36, 18);
            ddrLabel.TabIndex = 5;
            ddrLabel.Text = "Ddr:";
            // 
            // brandLabel
            // 
            brandLabel.AutoSize = true;
            brandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            brandLabel.Location = new System.Drawing.Point(489, 79);
            brandLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            brandLabel.Name = "brandLabel";
            brandLabel.Size = new System.Drawing.Size(51, 18);
            brandLabel.TabIndex = 7;
            brandLabel.Text = "Brand:";
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            quantityLabel.Location = new System.Drawing.Point(489, 145);
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
            unitPriceLabel.Location = new System.Drawing.Point(489, 217);
            unitPriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            unitPriceLabel.Name = "unitPriceLabel";
            unitPriceLabel.Size = new System.Drawing.Size(76, 18);
            unitPriceLabel.TabIndex = 13;
            unitPriceLabel.Text = "Unit Price:";
            // 
            // heatSinkLabel
            // 
            heatSinkLabel.AutoSize = true;
            heatSinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            heatSinkLabel.Location = new System.Drawing.Point(13, 308);
            heatSinkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            heatSinkLabel.Name = "heatSinkLabel";
            heatSinkLabel.Size = new System.Drawing.Size(69, 16);
            heatSinkLabel.TabIndex = 15;
            heatSinkLabel.Text = "Heat Sink:";
            heatSinkLabel.Click += new System.EventHandler(this.heatSinkLabel_Click);
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
            this.memoryBindingNavigator.DeleteItem = null;
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
            this.memoryBindingNavigatorSaveItem});
            this.memoryBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.memoryBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.memoryBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.memoryBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.memoryBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.memoryBindingNavigator.Name = "memoryBindingNavigator";
            this.memoryBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.memoryBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.memoryBindingNavigator.Size = new System.Drawing.Size(1023, 25);
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
            this.sizeTextBox.Location = new System.Drawing.Point(153, 76);
            this.sizeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.sizeTextBox.Name = "sizeTextBox";
            this.sizeTextBox.Size = new System.Drawing.Size(148, 24);
            this.sizeTextBox.TabIndex = 2;
            // 
            // rankTextBox
            // 
            this.rankTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memoryBindingSource, "Rank", true));
            this.rankTextBox.Location = new System.Drawing.Point(153, 147);
            this.rankTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.rankTextBox.Name = "rankTextBox";
            this.rankTextBox.Size = new System.Drawing.Size(148, 24);
            this.rankTextBox.TabIndex = 4;
            this.rankTextBox.TextChanged += new System.EventHandler(this.rankTextBox_TextChanged);
            // 
            // ddrTextBox
            // 
            this.ddrTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memoryBindingSource, "Ddr", true));
            this.ddrTextBox.Location = new System.Drawing.Point(153, 219);
            this.ddrTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ddrTextBox.Name = "ddrTextBox";
            this.ddrTextBox.Size = new System.Drawing.Size(148, 24);
            this.ddrTextBox.TabIndex = 6;
            // 
            // brandTextBox
            // 
            this.brandTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memoryBindingSource, "Brand", true));
            this.brandTextBox.Location = new System.Drawing.Point(646, 76);
            this.brandTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.brandTextBox.Name = "brandTextBox";
            this.brandTextBox.Size = new System.Drawing.Size(148, 24);
            this.brandTextBox.TabIndex = 8;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memoryBindingSource, "Quantity", true));
            this.quantityTextBox.Location = new System.Drawing.Point(646, 141);
            this.quantityTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(148, 24);
            this.quantityTextBox.TabIndex = 12;
            // 
            // unitPriceTextBox
            // 
            this.unitPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memoryBindingSource, "UnitPrice", true));
            this.unitPriceTextBox.Location = new System.Drawing.Point(646, 219);
            this.unitPriceTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.unitPriceTextBox.Name = "unitPriceTextBox";
            this.unitPriceTextBox.Size = new System.Drawing.Size(148, 24);
            this.unitPriceTextBox.TabIndex = 14;
            // 
            // heatSinkCheckBox
            // 
            this.heatSinkCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.memoryBindingSource, "HeatSink", true));
            this.heatSinkCheckBox.Location = new System.Drawing.Point(153, 291);
            this.heatSinkCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.heatSinkCheckBox.Name = "heatSinkCheckBox";
            this.heatSinkCheckBox.Size = new System.Drawing.Size(156, 33);
            this.heatSinkCheckBox.TabIndex = 16;
            this.heatSinkCheckBox.Text = "Available";
            this.heatSinkCheckBox.UseVisualStyleBackColor = true;
            // 
            // BackBtn
            // 
            this.BackBtn.AutoSize = true;
            this.BackBtn.Location = new System.Drawing.Point(952, 18);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(42, 18);
            this.BackBtn.TabIndex = 17;
            this.BackBtn.Text = "Back";
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // ComponentNameLbl
            // 
            this.ComponentNameLbl.AutoSize = true;
            this.ComponentNameLbl.Location = new System.Drawing.Point(464, 18);
            this.ComponentNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ComponentNameLbl.Name = "ComponentNameLbl";
            this.ComponentNameLbl.Size = new System.Drawing.Size(46, 18);
            this.ComponentNameLbl.TabIndex = 18;
            this.ComponentNameLbl.Text = "label1";
            // 
            // MemoryAddInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 485);
            this.Controls.Add(this.ComponentNameLbl);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(heatSinkLabel);
            this.Controls.Add(this.heatSinkCheckBox);
            this.Controls.Add(unitPriceLabel);
            this.Controls.Add(this.unitPriceTextBox);
            this.Controls.Add(quantityLabel);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(brandLabel);
            this.Controls.Add(this.brandTextBox);
            this.Controls.Add(ddrLabel);
            this.Controls.Add(this.ddrTextBox);
            this.Controls.Add(rankLabel);
            this.Controls.Add(this.rankTextBox);
            this.Controls.Add(sizeLabel);
            this.Controls.Add(this.sizeTextBox);
            this.Controls.Add(this.memoryBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox unitPriceTextBox;
        private System.Windows.Forms.CheckBox heatSinkCheckBox;
        private System.Windows.Forms.Label BackBtn;
        private System.Windows.Forms.Label ComponentNameLbl;
    }
}