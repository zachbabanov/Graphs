namespace Graphs
{
    partial class NodeProc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NodeProc));
            this.status_label = new System.Windows.Forms.Label();
            this.status_textbox = new System.Windows.Forms.TextBox();
            this.size_label = new System.Windows.Forms.Label();
            this.size_textbox = new System.Windows.Forms.TextBox();
            this.align_button = new System.Windows.Forms.Button();
            this.number_label = new System.Windows.Forms.Label();
            this.number_textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // status_label
            // 
            this.status_label.AutoSize = true;
            this.status_label.Location = new System.Drawing.Point(13, 13);
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(37, 13);
            this.status_label.TabIndex = 0;
            this.status_label.Text = "Status";
            // 
            // status_textbox
            // 
            this.status_textbox.Location = new System.Drawing.Point(56, 10);
            this.status_textbox.Name = "status_textbox";
            this.status_textbox.Size = new System.Drawing.Size(100, 20);
            this.status_textbox.TabIndex = 1;
            this.status_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // size_label
            // 
            this.size_label.AutoSize = true;
            this.size_label.Location = new System.Drawing.Point(13, 42);
            this.size_label.Name = "size_label";
            this.size_label.Size = new System.Drawing.Size(27, 13);
            this.size_label.TabIndex = 2;
            this.size_label.Text = "Size";
            // 
            // size_textbox
            // 
            this.size_textbox.Location = new System.Drawing.Point(56, 39);
            this.size_textbox.Name = "size_textbox";
            this.size_textbox.Size = new System.Drawing.Size(100, 20);
            this.size_textbox.TabIndex = 3;
            this.size_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // align_button
            // 
            this.align_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.align_button.Location = new System.Drawing.Point(36, 93);
            this.align_button.Name = "align_button";
            this.align_button.Size = new System.Drawing.Size(100, 44);
            this.align_button.TabIndex = 4;
            this.align_button.Text = "Align";
            this.align_button.UseVisualStyleBackColor = true;
            this.align_button.Click += new System.EventHandler(this.align_button_Click);
            // 
            // number_label
            // 
            this.number_label.AutoSize = true;
            this.number_label.Location = new System.Drawing.Point(13, 70);
            this.number_label.Name = "number_label";
            this.number_label.Size = new System.Drawing.Size(44, 13);
            this.number_label.TabIndex = 5;
            this.number_label.Text = "Number";
            // 
            // number_textbox
            // 
            this.number_textbox.Location = new System.Drawing.Point(56, 67);
            this.number_textbox.Name = "number_textbox";
            this.number_textbox.Size = new System.Drawing.Size(100, 20);
            this.number_textbox.TabIndex = 6;
            this.number_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // NodeProc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(172, 145);
            this.Controls.Add(this.number_textbox);
            this.Controls.Add(this.number_label);
            this.Controls.Add(this.align_button);
            this.Controls.Add(this.size_textbox);
            this.Controls.Add(this.size_label);
            this.Controls.Add(this.status_textbox);
            this.Controls.Add(this.status_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NodeProc";
            this.Text = "Vertex";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label status_label;
        private System.Windows.Forms.TextBox status_textbox;
        private System.Windows.Forms.Label size_label;
        private System.Windows.Forms.TextBox size_textbox;
        private System.Windows.Forms.Button align_button;
        private System.Windows.Forms.Label number_label;
        private System.Windows.Forms.TextBox number_textbox;
    }
}