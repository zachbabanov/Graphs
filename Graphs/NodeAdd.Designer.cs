namespace Graphs
{
    partial class NodeAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NodeAdd));
            this.to_textbox = new System.Windows.Forms.TextBox();
            this.from_textbox = new System.Windows.Forms.TextBox();
            this.newnode_button = new System.Windows.Forms.Button();
            this.bandwidth_textbox = new System.Windows.Forms.TextBox();
            this.from_label = new System.Windows.Forms.Label();
            this.to_label = new System.Windows.Forms.Label();
            this.bandwidth_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // to_textbox
            // 
            this.to_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.to_textbox.Location = new System.Drawing.Point(48, 33);
            this.to_textbox.Name = "to_textbox";
            this.to_textbox.Size = new System.Drawing.Size(100, 20);
            this.to_textbox.TabIndex = 0;
            this.to_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // from_textbox
            // 
            this.from_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.from_textbox.Location = new System.Drawing.Point(48, 7);
            this.from_textbox.Name = "from_textbox";
            this.from_textbox.Size = new System.Drawing.Size(100, 20);
            this.from_textbox.TabIndex = 1;
            this.from_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // newnode_button
            // 
            this.newnode_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newnode_button.Location = new System.Drawing.Point(33, 85);
            this.newnode_button.Name = "newnode_button";
            this.newnode_button.Size = new System.Drawing.Size(100, 48);
            this.newnode_button.TabIndex = 2;
            this.newnode_button.Text = "Add";
            this.newnode_button.UseVisualStyleBackColor = true;
            this.newnode_button.Click += new System.EventHandler(this.newnode_button_Click);
            // 
            // bandwidth_textbox
            // 
            this.bandwidth_textbox.Location = new System.Drawing.Point(48, 59);
            this.bandwidth_textbox.Name = "bandwidth_textbox";
            this.bandwidth_textbox.Size = new System.Drawing.Size(100, 20);
            this.bandwidth_textbox.TabIndex = 3;
            this.bandwidth_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // from_label
            // 
            this.from_label.AutoSize = true;
            this.from_label.Location = new System.Drawing.Point(12, 9);
            this.from_label.Name = "from_label";
            this.from_label.Size = new System.Drawing.Size(30, 13);
            this.from_label.TabIndex = 4;
            this.from_label.Text = "From";
            // 
            // to_label
            // 
            this.to_label.AutoSize = true;
            this.to_label.Location = new System.Drawing.Point(12, 35);
            this.to_label.Name = "to_label";
            this.to_label.Size = new System.Drawing.Size(20, 13);
            this.to_label.TabIndex = 5;
            this.to_label.Text = "To";
            // 
            // bandwidth_label
            // 
            this.bandwidth_label.AutoSize = true;
            this.bandwidth_label.Location = new System.Drawing.Point(12, 62);
            this.bandwidth_label.Name = "bandwidth_label";
            this.bandwidth_label.Size = new System.Drawing.Size(35, 13);
            this.bandwidth_label.TabIndex = 6;
            this.bandwidth_label.Text = "Width";
            // 
            // NodeAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(162, 151);
            this.Controls.Add(this.bandwidth_label);
            this.Controls.Add(this.to_label);
            this.Controls.Add(this.from_label);
            this.Controls.Add(this.bandwidth_textbox);
            this.Controls.Add(this.newnode_button);
            this.Controls.Add(this.from_textbox);
            this.Controls.Add(this.to_textbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NodeAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox to_textbox;
        private System.Windows.Forms.TextBox from_textbox;
        private System.Windows.Forms.Button newnode_button;
        private System.Windows.Forms.TextBox bandwidth_textbox;
        private System.Windows.Forms.Label from_label;
        private System.Windows.Forms.Label to_label;
        private System.Windows.Forms.Label bandwidth_label;
    }
}