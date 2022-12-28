using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphs
{
    public partial class Optimize : Form
    {
        double volume_value;
        public Optimize()
        {
            InitializeComponent();
        }

        private void optimize_button_Click(object sender, EventArgs e)
        {
            if (volume_textbox.Text.Trim() != String.Empty && double.TryParse(volume_textbox.Text, out double outputValue))
            {
                volume_value = double.Parse(volume_textbox.Text);
            }

            Graphs.ThisGraph.OptimizeCount(volume_value);
            this.Close();
        }
    }
}
