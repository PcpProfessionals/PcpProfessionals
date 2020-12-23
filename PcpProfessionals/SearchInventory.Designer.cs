
namespace PcpProfessionals
{
    partial class SearchInventory
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
            this.AvlCompLbl = new System.Windows.Forms.Label();
            this.ComponentListCb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // AvlCompLbl
            // 
            this.AvlCompLbl.AutoSize = true;
            this.AvlCompLbl.Location = new System.Drawing.Point(25, 45);
            this.AvlCompLbl.Name = "AvlCompLbl";
            this.AvlCompLbl.Size = new System.Drawing.Size(112, 13);
            this.AvlCompLbl.TabIndex = 0;
            this.AvlCompLbl.Text = "Available Components";
            this.AvlCompLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // ComponentListCb
            // 
            this.ComponentListCb.FormattingEnabled = true;
            this.ComponentListCb.Location = new System.Drawing.Point(168, 42);
            this.ComponentListCb.Name = "ComponentListCb";
            this.ComponentListCb.Size = new System.Drawing.Size(205, 21);
            this.ComponentListCb.TabIndex = 1;
            this.ComponentListCb.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // SearchInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ComponentListCb);
            this.Controls.Add(this.AvlCompLbl);
            this.Name = "SearchInventory";
            this.Text = "SearchInventory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AvlCompLbl;
        private System.Windows.Forms.ComboBox ComponentListCb;
    }
}