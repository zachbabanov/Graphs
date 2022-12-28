namespace Graphs
{
    partial class NodeDelete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NodeDelete));
            this.deletenode_button = new System.Windows.Forms.Button();
            this.graphsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.graphBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.graphsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.graphsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.nodedelete_textbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.graphsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphsBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // deletenode_button
            // 
            this.deletenode_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletenode_button.Location = new System.Drawing.Point(12, 40);
            this.deletenode_button.Name = "deletenode_button";
            this.deletenode_button.Size = new System.Drawing.Size(121, 38);
            this.deletenode_button.TabIndex = 1;
            this.deletenode_button.Text = "Delete";
            this.deletenode_button.UseVisualStyleBackColor = true;
            this.deletenode_button.Click += new System.EventHandler(this.deletenode_button_Click);
            // 
            // nodedelete_textbox
            // 
            this.nodedelete_textbox.Location = new System.Drawing.Point(13, 13);
            this.nodedelete_textbox.Name = "nodedelete_textbox";
            this.nodedelete_textbox.Size = new System.Drawing.Size(120, 20);
            this.nodedelete_textbox.TabIndex = 2;
            // 
            // NodeDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(146, 92);
            this.Controls.Add(this.nodedelete_textbox);
            this.Controls.Add(this.deletenode_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NodeDelete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Delete";
            ((System.ComponentModel.ISupportInitialize)(this.graphsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphsBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button deletenode_button;
        private System.Windows.Forms.BindingSource graphsBindingSource;
        private System.Windows.Forms.BindingSource graphBindingSource;
        private System.Windows.Forms.BindingSource graphsBindingSource1;
        private System.Windows.Forms.BindingSource graphsBindingSource2;
        private System.Windows.Forms.TextBox nodedelete_textbox;
    }
}