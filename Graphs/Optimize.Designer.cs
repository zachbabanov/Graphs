namespace Graphs
{
    partial class Optimize
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Optimize));
            this.volume_label = new System.Windows.Forms.Label();
            this.volume_textbox = new System.Windows.Forms.TextBox();
            this.optimize_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // volume_label
            // 
            this.volume_label.AutoSize = true;
            this.volume_label.Location = new System.Drawing.Point(12, 9);
            this.volume_label.Name = "volume_label";
            this.volume_label.Size = new System.Drawing.Size(80, 13);
            this.volume_label.TabIndex = 0;
            this.volume_label.Text = "Income Volume";
            // 
            // volume_textbox
            // 
            this.volume_textbox.Location = new System.Drawing.Point(98, 6);
            this.volume_textbox.Name = "volume_textbox";
            this.volume_textbox.Size = new System.Drawing.Size(100, 20);
            this.volume_textbox.TabIndex = 1;
            // 
            // optimize_button
            // 
            this.optimize_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optimize_button.Location = new System.Drawing.Point(54, 32);
            this.optimize_button.Name = "optimize_button";
            this.optimize_button.Size = new System.Drawing.Size(100, 33);
            this.optimize_button.TabIndex = 2;
            this.optimize_button.Text = "Optimize";
            this.optimize_button.UseVisualStyleBackColor = true;
            this.optimize_button.Click += new System.EventHandler(this.optimize_button_Click);
            // 
            // Optimize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 76);
            this.Controls.Add(this.optimize_button);
            this.Controls.Add(this.volume_textbox);
            this.Controls.Add(this.volume_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Optimize";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Optimization";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label volume_label;
        private System.Windows.Forms.TextBox volume_textbox;
        private System.Windows.Forms.Button optimize_button;
    }
}