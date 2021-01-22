
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
            System.Windows.Forms.Label modelNumberLabel;
            System.Windows.Forms.Label cacheSizeLabel;
            System.Windows.Forms.Label typeLabel;
            System.Windows.Forms.Label speedLabel;
            System.Windows.Forms.Label quantityLabel;
            System.Windows.Forms.Label unitPriceLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcessorAddInventory));
            this.pcpProfessionalDataSet = new PcpProfessionals.PcpProfessionalDataSet();
            this.processorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.processorTableAdapter = new PcpProfessionals.PcpProfessionalDataSetTableAdapters.ProcessorTableAdapter();
            this.tableAdapterManager = new PcpProfessionals.PcpProfessionalDataSetTableAdapters.TableAdapterManager();
            this.processorBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.processorBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.modelNumberTextBox = new System.Windows.Forms.TextBox();
            this.cacheSizeTextBox = new System.Windows.Forms.TextBox();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.speedTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.unitPriceTextBox = new System.Windows.Forms.TextBox();
            this.BackBtn = new System.Windows.Forms.Label();
            this.ComponentNameLbl = new System.Windows.Forms.Label();
            modelNumberLabel = new System.Windows.Forms.Label();
            cacheSizeLabel = new System.Windows.Forms.Label();
            typeLabel = new System.Windows.Forms.Label();
            speedLabel = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            unitPriceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcpProfessionalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processorBindingNavigator)).BeginInit();
            this.processorBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // modelNumberLabel
            // 
            modelNumberLabel.AutoSize = true;
            modelNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            modelNumberLabel.Location = new System.Drawing.Point(18, 89);
            modelNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            modelNumberLabel.Name = "modelNumberLabel";
            modelNumberLabel.Size = new System.Drawing.Size(110, 18);
            modelNumberLabel.TabIndex = 1;
            modelNumberLabel.Text = "Model Number:";
            // 
            // cacheSizeLabel
            // 
            cacheSizeLabel.AutoSize = true;
            cacheSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cacheSizeLabel.Location = new System.Drawing.Point(513, 93);
            cacheSizeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cacheSizeLabel.Name = "cacheSizeLabel";
            cacheSizeLabel.Size = new System.Drawing.Size(88, 18);
            cacheSizeLabel.TabIndex = 3;
            cacheSizeLabel.Text = "Cache Size:";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            typeLabel.Location = new System.Drawing.Point(513, 219);
            typeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(44, 18);
            typeLabel.TabIndex = 7;
            typeLabel.Text = "Type:";
            // 
            // speedLabel
            // 
            speedLabel.AutoSize = true;
            speedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            speedLabel.Location = new System.Drawing.Point(18, 156);
            speedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            speedLabel.Name = "speedLabel";
            speedLabel.Size = new System.Drawing.Size(54, 18);
            speedLabel.TabIndex = 9;
            speedLabel.Text = "Speed:";
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            quantityLabel.Location = new System.Drawing.Point(18, 219);
            quantityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(66, 18);
            quantityLabel.TabIndex = 13;
            quantityLabel.Text = "Quantity:";
            // 
            // unitPriceLabel
            // 
            unitPriceLabel.AutoSize = true;
            unitPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            unitPriceLabel.Location = new System.Drawing.Point(513, 156);
            unitPriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            unitPriceLabel.Name = "unitPriceLabel";
            unitPriceLabel.Size = new System.Drawing.Size(76, 18);
            unitPriceLabel.TabIndex = 15;
            unitPriceLabel.Text = "Unit Price:";
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
            this.processorBindingNavigator.DeleteItem = null;
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
            this.processorBindingNavigatorSaveItem});
            this.processorBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.processorBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.processorBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.processorBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.processorBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.processorBindingNavigator.Name = "processorBindingNavigator";
            this.processorBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.processorBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.processorBindingNavigator.Size = new System.Drawing.Size(1014, 25);
            this.processorBindingNavigator.TabIndex = 0;
            this.processorBindingNavigator.Text = "bindingNavigator1";
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
            // processorBindingNavigatorSaveItem
            // 
            this.processorBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.processorBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("processorBindingNavigatorSaveItem.Image")));
            this.processorBindingNavigatorSaveItem.Name = "processorBindingNavigatorSaveItem";
            this.processorBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.processorBindingNavigatorSaveItem.Text = "Save Data";
            this.processorBindingNavigatorSaveItem.Click += new System.EventHandler(this.processorBindingNavigatorSaveItem_Click);
            // 
            // modelNumberTextBox
            // 
            this.modelNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.processorBindingSource, "ModelNumber", true));
            this.modelNumberTextBox.Location = new System.Drawing.Point(243, 86);
            this.modelNumberTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.modelNumberTextBox.Name = "modelNumberTextBox";
            this.modelNumberTextBox.Size = new System.Drawing.Size(148, 24);
            this.modelNumberTextBox.TabIndex = 2;
            // 
            // cacheSizeTextBox
            // 
            this.cacheSizeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.processorBindingSource, "CacheSize", true));
            this.cacheSizeTextBox.Location = new System.Drawing.Point(681, 94);
            this.cacheSizeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.cacheSizeTextBox.Name = "cacheSizeTextBox";
            this.cacheSizeTextBox.Size = new System.Drawing.Size(148, 24);
            this.cacheSizeTextBox.TabIndex = 4;
            // 
            // typeTextBox
            // 
            this.typeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.processorBindingSource, "Type", true));
            this.typeTextBox.Location = new System.Drawing.Point(681, 216);
            this.typeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(148, 24);
            this.typeTextBox.TabIndex = 8;
            // 
            // speedTextBox
            // 
            this.speedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.processorBindingSource, "Speed", true));
            this.speedTextBox.Location = new System.Drawing.Point(243, 154);
            this.speedTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.speedTextBox.Name = "speedTextBox";
            this.speedTextBox.Size = new System.Drawing.Size(148, 24);
            this.speedTextBox.TabIndex = 10;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.processorBindingSource, "Quantity", true));
            this.quantityTextBox.Location = new System.Drawing.Point(243, 216);
            this.quantityTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(148, 24);
            this.quantityTextBox.TabIndex = 14;
            // 
            // unitPriceTextBox
            // 
            this.unitPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.processorBindingSource, "UnitPrice", true));
            this.unitPriceTextBox.Location = new System.Drawing.Point(681, 154);
            this.unitPriceTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.unitPriceTextBox.Name = "unitPriceTextBox";
            this.unitPriceTextBox.Size = new System.Drawing.Size(148, 24);
            this.unitPriceTextBox.TabIndex = 16;
            // 
            // BackBtn
            // 
            this.BackBtn.AutoSize = true;
            this.BackBtn.Location = new System.Drawing.Point(944, 18);
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
            this.ComponentNameLbl.Location = new System.Drawing.Point(478, 18);
            this.ComponentNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ComponentNameLbl.Name = "ComponentNameLbl";
            this.ComponentNameLbl.Size = new System.Drawing.Size(46, 18);
            this.ComponentNameLbl.TabIndex = 18;
            this.ComponentNameLbl.Text = "label1";
            // 
            // ProcessorAddInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 417);
            this.Controls.Add(this.ComponentNameLbl);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(unitPriceLabel);
            this.Controls.Add(this.unitPriceTextBox);
            this.Controls.Add(quantityLabel);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(speedLabel);
            this.Controls.Add(this.speedTextBox);
            this.Controls.Add(typeLabel);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(cacheSizeLabel);
            this.Controls.Add(this.cacheSizeTextBox);
            this.Controls.Add(modelNumberLabel);
            this.Controls.Add(this.modelNumberTextBox);
            this.Controls.Add(this.processorBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.TextBox speedTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox unitPriceTextBox;
        private System.Windows.Forms.Label BackBtn;
        private System.Windows.Forms.Label ComponentNameLbl;
    }
}