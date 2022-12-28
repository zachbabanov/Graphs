using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Graphs
{
    public partial class Graphs : Form
    {
        public static Graph ThisGraph = new Graph(0, 0);
        public static int CurrentNumOfWeights = 0;
        public static int CurrentNumOfTops = 0;
        public static List<GraphNode> graphholder = new List<GraphNode>();
        public static int NumberOfNode = 0;

        public int[,] matrex = ThisGraph.getMatrix();

        public class ControlWriter : TextWriter
        {
            private Control textbox;
            public ControlWriter(Control textbox)
            {
                this.textbox = textbox;
            }

            public override void Write(char value)
            {
                textbox.Text += value;
            }

            public override void Write(string value)
            {
                textbox.Text += value;
            }

            public override Encoding Encoding
            {
                get { return Encoding.UTF8; }
            }
        }

        public Graphs()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.SetOut(new ControlWriter(console_textbox));
            ThisGraph.graph.Capacity = CurrentNumOfWeights;
            graphholder.Sort((s1, s2) => s1.from.CompareTo(s2.from));
            ThisGraph.setGraph(graphholder);
            matrex = ThisGraph.getMatrix();
            conjPanel1.Build(matrex);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NodeAdd nodeAdd = new NodeAdd();
            nodeAdd.ShowDialog();
            matrex = ThisGraph.getMatrix();
            conjPanel1.CreateNodes(matrex);
            int count = 0;
            /*for (int i = 0; i < CurrentNumOfTops; i++)
            {
                int count_1 = 0;
                for (int j = 0; j < CurrentNumOfTops; j++)
                {
                    if (matrex[i, j] == 1)
                    {
                        conjPanel1._nodes[i].Linked[count_1].Label1 = ThisGraph.graph.ToArray()[count].getWeight();
                        count++;
                        count_1++;
                    }
                        
                }
            }*/
            conjPanel1.Build(matrex);
            if (nodeAdd.isOpened)
                node_table.Rows.Add(new object[] { nodeAdd.from_value, nodeAdd.to_value, nodeAdd.bandwidth_value });
            node_table.Sort(node_table.Columns[1], ListSortDirection.Ascending);
            ThisGraph.graph.Sort((s1, s2) => s1.from.CompareTo(s2.from));
        }

        private void deleteNodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NodeDelete nodeDelete = new NodeDelete();
            nodeDelete.ShowDialog();
            matrex = ThisGraph.getMatrix();
            conjPanel1.CreateNodes(matrex);
            for (int i = 0; i < CurrentNumOfWeights; i++)
            conjPanel1.Build(matrex);
            if (nodeDelete.isOpened)
            node_table.Sort(node_table.Columns[1], ListSortDirection.Ascending);
            ThisGraph.graph.Sort((s1, s2) => s1.from.CompareTo(s2.from));
        }

        private void deleteGraphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThisGraph.graph.Clear();
            ThisGraph.setNum_of_tops(0);
            ThisGraph.setNum_of_weights(0);
            matrex = ThisGraph.getMatrix();
            conjPanel1.CreateNodes(matrex);
            conjPanel1.Build(matrex);
        }

        private void findMaxFlowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThisGraph.maxFlow();
        }

        private void optimizeVolumeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Optimize optimize = new Optimize();
            optimize.ShowDialog();
        }

        private void getWorkFlowToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void vertexParametersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NodeProc nodeProc = new NodeProc();
            nodeProc.ShowDialog();
        }
    }
}
