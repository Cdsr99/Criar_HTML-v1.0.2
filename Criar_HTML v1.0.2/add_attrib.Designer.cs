namespace Criar_HTML_v1._0._2
{
    partial class add_attrib
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
            this.all = new System.Windows.Forms.CheckBox();
            this.eggs = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // all
            // 
            this.all.AutoSize = true;
            this.all.Location = new System.Drawing.Point(28, 48);
            this.all.Name = "all";
            this.all.Size = new System.Drawing.Size(69, 17);
            this.all.TabIndex = 18;
            this.all.Text = "Select all";
            this.all.UseVisualStyleBackColor = true;
            // 
            // eggs
            // 
            this.eggs.AutoSize = true;
            this.eggs.Location = new System.Drawing.Point(144, 233);
            this.eggs.Name = "eggs";
            this.eggs.Size = new System.Drawing.Size(49, 17);
            this.eggs.TabIndex = 17;
            this.eggs.Text = "eggs";
            this.eggs.UseVisualStyleBackColor = true;
            // 
            // add_attrib
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.all);
            this.Controls.Add(this.eggs);
            this.Name = "add_attrib";
            this.Text = "add_attrib";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox all;
        private System.Windows.Forms.CheckBox eggs;
    }
}