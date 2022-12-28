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
    public partial class NodeProc : Form
    {
        public bool status_value;
        public double size_value;
        public int number_value;

        public NodeProc()
        {
            InitializeComponent();
        }

        private void align_button_Click(object sender, EventArgs e)
        {


            if (status_textbox.Text.Trim() != String.Empty && bool.TryParse(status_textbox.Text, out bool outputValue))
            {
                status_value = bool.Parse(status_textbox.Text);
            }

            if (size_textbox.Text.Trim() != String.Empty && double.TryParse(size_textbox.Text, out double outputValue1))
            {
                size_value = double.Parse(size_textbox.Text);
            }

            if (number_textbox.Text.Trim() != String.Empty && int.TryParse(number_textbox.Text, out int outputValue3))
            {
                number_value = int.Parse(number_textbox.Text);
            }

            Graphs.ThisGraph.addNodeParameter(status_value, size_value);
           

            //Graphs.ThisGraph.nodeProcessing.Add(new NodeProcessing(status_value, size_value, number_value));
            //Graphs.ThisGraph.nodeProcessing.Sort((s1, s2) => s1.number.CompareTo(s2.number));

            this.Close();
        }
    }
}
