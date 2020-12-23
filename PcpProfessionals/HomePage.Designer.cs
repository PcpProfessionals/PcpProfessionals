
namespace PcpProfessionals
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.PurchaseModuleBtn = new System.Windows.Forms.Button();
            this.InventoryModuleBtn = new System.Windows.Forms.Button();
            this.ReportModuleBtn = new System.Windows.Forms.Button();
            this.SalesModuleBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PurchaseModuleBtn
            // 
            this.PurchaseModuleBtn.Location = new System.Drawing.Point(12, 122);
            this.PurchaseModuleBtn.Name = "PurchaseModuleBtn";
            this.PurchaseModuleBtn.Size = new System.Drawing.Size(177, 89);
            this.PurchaseModuleBtn.TabIndex = 0;
            this.PurchaseModuleBtn.Text = "Purchase Module";
            this.PurchaseModuleBtn.UseVisualStyleBackColor = true;
            // 
            // InventoryModuleBtn
            // 
            this.InventoryModuleBtn.Location = new System.Drawing.Point(12, 229);
            this.InventoryModuleBtn.Name = "InventoryModuleBtn";
            this.InventoryModuleBtn.Size = new System.Drawing.Size(177, 92);
            this.InventoryModuleBtn.TabIndex = 1;
            this.InventoryModuleBtn.Text = "Inventory Module";
            this.InventoryModuleBtn.UseVisualStyleBackColor = true;
            this.InventoryModuleBtn.Click += new System.EventHandler(this.InventoryModuleBtn_Click);
            // 
            // ReportModuleBtn
            // 
            this.ReportModuleBtn.Location = new System.Drawing.Point(213, 230);
            this.ReportModuleBtn.Name = "ReportModuleBtn";
            this.ReportModuleBtn.Size = new System.Drawing.Size(177, 91);
            this.ReportModuleBtn.TabIndex = 2;
            this.ReportModuleBtn.Text = "Report Generator";
            this.ReportModuleBtn.UseVisualStyleBackColor = true;
            // 
            // SalesModuleBtn
            // 
            this.SalesModuleBtn.Location = new System.Drawing.Point(213, 122);
            this.SalesModuleBtn.Name = "SalesModuleBtn";
            this.SalesModuleBtn.Size = new System.Drawing.Size(177, 89);
            this.SalesModuleBtn.TabIndex = 3;
            this.SalesModuleBtn.Text = "Sales Module";
            this.SalesModuleBtn.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(304, 85);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 338);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SalesModuleBtn);
            this.Controls.Add(this.ReportModuleBtn);
            this.Controls.Add(this.InventoryModuleBtn);
            this.Controls.Add(this.PurchaseModuleBtn);
            this.Name = "HomePage";
            this.Text = "HomePage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PurchaseModuleBtn;
        private System.Windows.Forms.Button InventoryModuleBtn;
        private System.Windows.Forms.Button ReportModuleBtn;
        private System.Windows.Forms.Button SalesModuleBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}