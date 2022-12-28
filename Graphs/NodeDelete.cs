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
    public partial class NodeDelete : Form
    {
        public bool isOpened;
        public int nodedelete_value;
        public NodeDelete()
        {
            InitializeComponent();
        }

        private void deletenode_button_Click(object sender, EventArgs e)
        {
            isOpened = true;
            if (nodedelete_textbox.Text.Trim() != String.Empty && int.TryParse(nodedelete_textbox.Text, out int outputValue))
            {
                nodedelete_value = int.Parse(nodedelete_textbox.Text);
            }

            if (nodedelete_value > Graphs.ThisGraph.num_of_weights)
                throw new Exception("non existing node");

            Graphs.ThisGraph.deleteGraphNode(nodedelete_value-1);
            Graphs.CurrentNumOfWeights--;
            Graphs.ThisGraph.num_of_weights = Graphs.CurrentNumOfWeights;
            this.Close();
        }
    }
}
