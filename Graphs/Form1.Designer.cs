namespace Graphs
{
    partial class Graphs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Graphs));
            this.graphs_menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteNodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteGraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.functionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findMaxFlowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optimizeVolumeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.conjPanel1 = new System.Windows.Forms.AdjPanel();
            this.node_table = new System.Windows.Forms.DataGridView();
            this.from_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.to_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bandwidth_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.console_textbox = new System.Windows.Forms.TextBox();
            this.vertexParametersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graphs_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.node_table)).BeginInit();
            this.SuspendLayout();
            // 
            // graphs_menu
            // 
            this.graphs_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.functionsToolStripMenuItem});
            this.graphs_menu.Location = new System.Drawing.Point(0, 0);
            this.graphs_menu.Name = "graphs_menu";
            this.graphs_menu.Size = new System.Drawing.Size(892, 24);
            this.graphs_menu.TabIndex = 1;
            this.graphs_menu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.vertexParametersToolStripMenuItem,
            this.deleteNodeToolStripMenuItem,
            this.deleteGraphToolStripMenuItem});
            this.fileToolStripMenuItem.Image = global::Graphs.Properties.Resources.Graphs_AddNewGraphButton_Icon;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.fileToolStripMenuItem.Text = "Graphs";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "Add new node";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // deleteNodeToolStripMenuItem
            // 
            this.deleteNodeToolStripMenuItem.Name = "deleteNodeToolStripMenuItem";
            this.deleteNodeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteNodeToolStripMenuItem.Text = "Delete node";
            this.deleteNodeToolStripMenuItem.Click += new System.EventHandler(this.deleteNodeToolStripMenuItem_Click);
            // 
            // deleteGraphToolStripMenuItem
            // 
            this.deleteGraphToolStripMenuItem.Name = "deleteGraphToolStripMenuItem";
            this.deleteGraphToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteGraphToolStripMenuItem.Text = "Delete graph";
            this.deleteGraphToolStripMenuItem.Click += new System.EventHandler(this.deleteGraphToolStripMenuItem_Click);
            // 
            // functionsToolStripMenuItem
            // 
            this.functionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findMaxFlowToolStripMenuItem,
            this.optimizeVolumeToolStripMenuItem});
            this.functionsToolStripMenuItem.Image = global::Graphs.Properties.Resources.Graphs_OptimizeButton_Icon;
            this.functionsToolStripMenuItem.Name = "functionsToolStripMenuItem";
            this.functionsToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.functionsToolStripMenuItem.Text = "Functions";
            // 
            // findMaxFlowToolStripMenuItem
            // 
            this.findMaxFlowToolStripMenuItem.Name = "findMaxFlowToolStripMenuItem";
            this.findMaxFlowToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.findMaxFlowToolStripMenuItem.Text = "Find max flow";
            this.findMaxFlowToolStripMenuItem.Click += new System.EventHandler(this.findMaxFlowToolStripMenuItem_Click);
            // 
            // optimizeVolumeToolStripMenuItem
            // 
            this.optimizeVolumeToolStripMenuItem.Name = "optimizeVolumeToolStripMenuItem";
            this.optimizeVolumeToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.optimizeVolumeToolStripMenuItem.Text = "Optimize volume";
            this.optimizeVolumeToolStripMenuItem.Click += new System.EventHandler(this.optimizeVolumeToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.console_textbox);
            this.splitContainer1.Size = new System.Drawing.Size(892, 543);
            this.splitContainer1.SplitterDistance = 376;
            this.splitContainer1.TabIndex = 2;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.conjPanel1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.node_table);
            this.splitContainer2.Size = new System.Drawing.Size(892, 376);
            this.splitContainer2.SplitterDistance = 630;
            this.splitContainer2.TabIndex = 0;
            // 
            // conjPanel1
            // 
            this.conjPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conjPanel1.Location = new System.Drawing.Point(0, 0);
            this.conjPanel1.Name = "conjPanel1";
            this.conjPanel1.Size = new System.Drawing.Size(630, 376);
            this.conjPanel1.TabIndex = 0;
            // 
            // node_table
            // 
            this.node_table.AllowUserToAddRows = false;
            this.node_table.AllowUserToDeleteRows = false;
            this.node_table.AllowUserToResizeColumns = false;
            this.node_table.AllowUserToResizeRows = false;
            this.node_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.node_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.from_column,
            this.to_column,
            this.bandwidth_column});
            this.node_table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.node_table.Location = new System.Drawing.Point(0, 0);
            this.node_table.Name = "node_table";
            this.node_table.Size = new System.Drawing.Size(258, 376);
            this.node_table.TabIndex = 0;
            // 
            // from_column
            // 
            this.from_column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.from_column.HeaderText = "From";
            this.from_column.Name = "from_column";
            this.from_column.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // to_column
            // 
            this.to_column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.to_column.HeaderText = "To";
            this.to_column.Name = "to_column";
            this.to_column.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // bandwidth_column
            // 
            this.bandwidth_column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bandwidth_column.HeaderText = "Bandwidth";
            this.bandwidth_column.Name = "bandwidth_column";
            this.bandwidth_column.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // console_textbox
            // 
            this.console_textbox.BackColor = System.Drawing.SystemColors.WindowText;
            this.console_textbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.console_textbox.ForeColor = System.Drawing.SystemColors.Window;
            this.console_textbox.Location = new System.Drawing.Point(0, 0);
            this.console_textbox.Multiline = true;
            this.console_textbox.Name = "console_textbox";
            this.console_textbox.ReadOnly = true;
            this.console_textbox.Size = new System.Drawing.Size(892, 163);
            this.console_textbox.TabIndex = 0;
            // 
            // vertexParametersToolStripMenuItem
            // 
            this.vertexParametersToolStripMenuItem.Name = "vertexParametersToolStripMenuItem";
            this.vertexParametersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vertexParametersToolStripMenuItem.Text = "Vertex parameters";
            this.vertexParametersToolStripMenuItem.Click += new System.EventHandler(this.vertexParametersToolStripMenuItem_Click);
            // 
            // Graphs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 567);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.graphs_menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Graphs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graphs";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.graphs_menu.ResumeLayout(false);
            this.graphs_menu.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.node_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn From;
        private System.Windows.Forms.DataGridViewTextBoxColumn To;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bandwidth;
        private System.Windows.Forms.MenuStrip graphs_menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteNodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteGraphToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem functionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findMaxFlowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optimizeVolumeToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridViewTextBoxColumn from_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn to_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn bandwidth_column;
        private System.Windows.Forms.TextBox console_textbox;
        private System.Windows.Forms.AdjPanel conjPanel1;
        public System.Windows.Forms.DataGridView node_table;
        private System.Windows.Forms.ToolStripMenuItem vertexParametersToolStripMenuItem;
    }
}

