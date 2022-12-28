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
    public partial class NodeAdd : Form
    {
        public int from_value;
        public int to_value;
        public double bandwidth_value;
        public bool isOpened;

        public NodeAdd()
        {
            InitializeComponent();
        }

        private void newnode_button_Click(object sender, EventArgs e)
        {
            isOpened = true;

            if (from_textbox.Text.Trim() != String.Empty && int.TryParse(from_textbox.Text, out int outputValue))
            {
                from_value = int.Parse(from_textbox.Text);
            }

            if (to_textbox.Text.Trim() != String.Empty && int.TryParse(to_textbox.Text, out outputValue))
            {
                to_value = int.Parse(to_textbox.Text);
            }

            if (bandwidth_textbox.Text.Trim() != String.Empty && double.TryParse(bandwidth_textbox.Text, out double outputValue1))
            {
                bandwidth_value = double.Parse(bandwidth_textbox.Text);
            }

            for (int i = 0; i < Graphs.ThisGraph.num_of_weights; i++)
            {
                if (from_value == Graphs.ThisGraph.graph.ToArray()[i].getFrom() && to_value == Graphs.ThisGraph.graph.ToArray()[i].getTo())
                    throw new Exception("Existing node");
            }

            
            Graphs.ThisGraph.graph.Capacity++;
            Graphs.CurrentNumOfWeights++;
            Graphs.ThisGraph.setNum_of_weights(Graphs.CurrentNumOfWeights);

            bool from_flag = false;
            bool to_flag = false;
            if (Graphs.ThisGraph.getNum_of_tops() != 0)
            {
                int i = 0;
                while(from_value != Graphs.ThisGraph.graph.ToArray()[i].getFrom() | from_value != Graphs.ThisGraph.graph.ToArray()[i].getTo() | i != Graphs.ThisGraph.graph.Count())
                {
                    if (from_value == Graphs.ThisGraph.graph.ToArray()[i].getFrom() || from_value == Graphs.ThisGraph.graph.ToArray()[i].getTo())
                        from_flag = true;
                    i++;
                    if (i >= Graphs.ThisGraph.graph.Count())
                        break;
                }
                
                int j = 0;
                while (to_value != Graphs.ThisGraph.graph.ToArray()[j].getFrom() | to_value != Graphs.ThisGraph.graph.ToArray()[j].getTo() | i != Graphs.ThisGraph.graph.Count())
                {
                    if (to_value == Graphs.ThisGraph.graph.ToArray()[j].getFrom() || to_value == Graphs.ThisGraph.graph.ToArray()[j].getTo())
                        to_flag = true;
                    j++;
                    if (j >= Graphs.ThisGraph.graph.Count())
                        break;
                }
            }

            if (from_flag)
            {
                if(to_flag)
                {
                    Graphs.ThisGraph.setNum_of_tops(Graphs.CurrentNumOfTops);
                }
                else
                {
                    Graphs.CurrentNumOfTops++;
                    Graphs.ThisGraph.setNum_of_tops(Graphs.CurrentNumOfTops);
                }
            }
            else
            {
                Graphs.CurrentNumOfTops = Graphs.CurrentNumOfTops + 2;
                Graphs.ThisGraph.setNum_of_tops(Graphs.CurrentNumOfTops);
            }

            Graphs.ThisGraph.addGraphNode(from_value, to_value, bandwidth_value);
            Graphs.ThisGraph.adj.Add(new List<int>());

            Graphs.ThisGraph.isWorking = new bool[Graphs.ThisGraph.num_of_weights];
            Graphs.ThisGraph.tops_array_from = new int[Graphs.ThisGraph.num_of_tops];
            Graphs.ThisGraph.Count_array = new double[Graphs.ThisGraph.num_of_tops];
            Graphs.ThisGraph.matrix = new double[Graphs.ThisGraph.num_of_tops, Graphs.ThisGraph.num_of_tops];
            for (int k = 0; k < Graphs.ThisGraph.num_of_weights; k++)
            {
                Graphs.ThisGraph.isWorking[k] = true;
                
            }
            for (int k = 0; k < Graphs.ThisGraph.num_of_tops; k++)
            {
                Graphs.ThisGraph.tops_array_from[k] = 0;
                for (int t = 0; t < Graphs.ThisGraph.num_of_tops; t++)
                {
                    Graphs.ThisGraph.matrix[k, t] = 0;
                }
            }
            
            this.Close();
        }
    }
}
