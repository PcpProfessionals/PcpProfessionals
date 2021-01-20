
namespace PcpProfessionals
{
    partial class InventoryPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryPage));
            this.RptGenBtn = new System.Windows.Forms.Button();
            this.SearchInvBtn = new System.Windows.Forms.Button();
            this.AnalyseInvBtn = new System.Windows.Forms.Button();
            this.BiBtn = new System.Windows.Forms.Button();
            this.AddInvBtn = new System.Windows.Forms.Button();
            this.CompManagerBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BackBtn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // RptGenBtn
            // 
            this.RptGenBtn.Location = new System.Drawing.Point(549, 286);
            this.RptGenBtn.Name = "RptGenBtn";
            this.RptGenBtn.Size = new System.Drawing.Size(177, 70);
            this.RptGenBtn.TabIndex = 0;
            this.RptGenBtn.Text = "Report Generator";
            this.RptGenBtn.UseVisualStyleBackColor = true;
            // 
            // SearchInvBtn
            // 
            this.SearchInvBtn.Location = new System.Drawing.Point(56, 166);
            this.SearchInvBtn.Name = "SearchInvBtn";
            this.SearchInvBtn.Size = new System.Drawing.Size(177, 70);
            this.SearchInvBtn.TabIndex = 1;
            this.SearchInvBtn.Text = "Search Inventory";
            this.SearchInvBtn.UseVisualStyleBackColor = true;
            this.SearchInvBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // AnalyseInvBtn
            // 
            this.AnalyseInvBtn.Location = new System.Drawing.Point(56, 286);
            this.AnalyseInvBtn.Name = "AnalyseInvBtn";
            this.AnalyseInvBtn.Size = new System.Drawing.Size(177, 70);
            this.AnalyseInvBtn.TabIndex = 2;
            this.AnalyseInvBtn.Text = "Analyse Inventory";
            this.AnalyseInvBtn.UseVisualStyleBackColor = true;
            // 
            // BiBtn
            // 
            this.BiBtn.Location = new System.Drawing.Point(549, 166);
            this.BiBtn.Name = "BiBtn";
            this.BiBtn.Size = new System.Drawing.Size(177, 70);
            this.BiBtn.TabIndex = 3;
            this.BiBtn.Text = "Business Intelligence";
            this.BiBtn.UseVisualStyleBackColor = true;
            // 
            // AddInvBtn
            // 
            this.AddInvBtn.Location = new System.Drawing.Point(302, 166);
            this.AddInvBtn.Name = "AddInvBtn";
            this.AddInvBtn.Size = new System.Drawing.Size(177, 70);
            this.AddInvBtn.TabIndex = 4;
            this.AddInvBtn.Text = "Add Inventory";
            this.AddInvBtn.UseVisualStyleBackColor = true;
            this.AddInvBtn.Click += new System.EventHandler(this.AddInvBtn_Click);
            // 
            // CompManagerBtn
            // 
            this.CompManagerBtn.Location = new System.Drawing.Point(302, 286);
            this.CompManagerBtn.Name = "CompManagerBtn";
            this.CompManagerBtn.Size = new System.Drawing.Size(177, 70);
            this.CompManagerBtn.TabIndex = 5;
            this.CompManagerBtn.Text = "Component Manager";
            this.CompManagerBtn.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(66, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(305, 101);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // BackBtn
            // 
            this.BackBtn.AutoSize = true;
            this.BackBtn.Location = new System.Drawing.Point(753, 13);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(32, 13);
            this.BackBtn.TabIndex = 7;
            this.BackBtn.Text = "Back";
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // InventoryPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CompManagerBtn);
            this.Controls.Add(this.AddInvBtn);
            this.Controls.Add(this.BiBtn);
            this.Controls.Add(this.AnalyseInvBtn);
            this.Controls.Add(this.SearchInvBtn);
            this.Controls.Add(this.RptGenBtn);
            this.Name = "InventoryPage";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RptGenBtn;
        private System.Windows.Forms.Button SearchInvBtn;
        private System.Windows.Forms.Button AnalyseInvBtn;
        private System.Windows.Forms.Button BiBtn;
        private System.Windows.Forms.Button AddInvBtn;
        private System.Windows.Forms.Button CompManagerBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label BackBtn;
    }
}