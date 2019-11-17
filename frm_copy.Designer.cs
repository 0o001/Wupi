namespace wupi
{
    partial class frm_copy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_copy));
            this.btn_copy = new System.Windows.Forms.Button();
            this.txt_copy = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_copy
            // 
            this.btn_copy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_copy.Location = new System.Drawing.Point(16, 16);
            this.btn_copy.Margin = new System.Windows.Forms.Padding(4);
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.Size = new System.Drawing.Size(100, 27);
            this.btn_copy.TabIndex = 0;
            this.btn_copy.Text = "Kopyala";
            this.btn_copy.UseVisualStyleBackColor = true;
            this.btn_copy.Click += new System.EventHandler(this.btn_copy_Click);
            // 
            // txt_copy
            // 
            this.txt_copy.BackColor = System.Drawing.Color.White;
            this.txt_copy.Location = new System.Drawing.Point(124, 17);
            this.txt_copy.Margin = new System.Windows.Forms.Padding(4);
            this.txt_copy.Name = "txt_copy";
            this.txt_copy.ReadOnly = true;
            this.txt_copy.Size = new System.Drawing.Size(305, 22);
            this.txt_copy.TabIndex = 1;
            // 
            // frm_copy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 55);
            this.Controls.Add(this.txt_copy);
            this.Controls.Add(this.btn_copy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_copy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Wupi - Wallhaven Wallpapers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_copy;
        private System.Windows.Forms.TextBox txt_copy;
    }
}