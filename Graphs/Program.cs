using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;
using System.IO;
using System.Threading;


namespace Graphs
{
    public class MaxFlow_Ford_Fulkerson
    {

        public static double findMaxFlow(double[,] arr, int source, int sink, int vertices)
        {
            //residual graph
            double[,] residualGraph = new double[vertices, vertices];

            //initialize residual graph same as original graph
            for (int i = 0; i < vertices; i++)
            {
                for (int j = 0; j < vertices; j++)
                {
                    residualGraph[i, j] = arr[i, j];
                }
            }

            //initialize parent [] to store the path Source to destination
            int[] parent = new int[vertices];

            double max_flow = 0; //initialize the max flow

            while (isPathExist_BFS(residualGraph, source, sink, parent, vertices))
            {
                //if here means still path exist from source to destination

                //parent [] will have the path from source to destination
                //find the capacity which can be passed though the path (in parent[])

                double flow_capacity = int.MaxValue;

                int t = sink;
                while (t != source)
                {
                    int s = parent[t];
                    flow_capacity = Math.Min(flow_capacity, residualGraph[s, t]);
                    t = s;
                }

                //update the residual graph
                //reduce the capacity on fwd edge by flow_capacity
                //add the capacity on back edge by flow_capacity
                t = sink;
                while (t != source)
                {
                    int s = parent[t];
                    residualGraph[s, t] -= flow_capacity;
                    residualGraph[t, s] += flow_capacity;
                    t = s;
                }

                //add flow_capacity to max value
                max_flow += flow_capacity;
            }
            return max_flow;
        }

        public static bool isPathExist_BFS(double[,] residualGraph, int src, int dest, int[] parent, int vertices)
        {
            bool pathFound = false;

            //create visited array [] to
            //keep track of visited vertices
            bool[] visited = new bool[vertices];

            //Create a queue for BFS
            Queue<int> queue = new Queue<int>();

            //insert the source vertex, mark it visited
            queue.Enqueue(src);
            parent[src] = -1;
            visited[src] = true;

            while (queue.Count() != 0)
            {
                int u = queue.Dequeue();

                //visit all the adjacent vertices
                for (int v = 0; v < vertices; v++)
                {
                    //if vertex is not already visited and u-v edge weight >0
                    if (!visited[v] && residualGraph[u, v] > 0)
                    {
                        queue.Enqueue(v);
                        parent[v] = u;
                        visited[v] = true;
                    }
                }
            }
            //check if dest is reached during BFS
            pathFound = visited[dest];
            return pathFound;
        }
    }
    
    public class NodeProcessing
    {
        public double lambda, size, timeProcessing, average_time_for_one_thread, sum_of_time, max_size, total_size;
        public int top, number_of_threads;
        public bool isWorking;
        public NodeProcessing()
        {

        }
        public NodeProcessing(bool isWorking,double max_size)
        {
            this.isWorking = isWorking;
            this.max_size = max_size;
        }
        public void calcTime()
        {
            average_time_for_one_thread = sum_of_time / number_of_threads;
            lambda = average_time_for_one_thread / number_of_threads;
            timeProcessing = getTimeProcessing() + 1 - (Math.Exp(-lambda * max_size));
            setTimeProcessing(timeProcessing);
        }

        public int getNumber_of_threads()
        {
            return number_of_threads;
        }

        public void setNumber_of_threads(int number_of_threads)
        {
            this.number_of_threads = number_of_threads;
        }

        public double getAverage_time_for_one_thread()
        {
            return average_time_for_one_thread;
        }

        public void setAverage_time_for_one_thread(double average_time_for_one_thread)
        {
            this.average_time_for_one_thread = average_time_for_one_thread;
        }

        public double getLambda()
        {
            return lambda;
        }

        public void setLambda(double lambda)
        {
            this.lambda = lambda;
        }

        public double getSize()
        {
            return max_size;
        }

        public void setCount(double Count)
        {
            this.max_size = Count;
        }

        public double getTimeProcessing()
        {
            return timeProcessing;
        }

        public void setTimeProcessing(double timeProcessing)
        {
            this.timeProcessing = timeProcessing;
        }

        public int getTop()
        {
            return top;
        }

        public void setTop(int top)
        {
            this.top = top;
        }

        public double getSum_of_time()
        {
            return sum_of_time;
        }

        public void setSum_of_time(double sum_of_time)
        {
            this.sum_of_time = sum_of_time;
        }

        public bool IsWorking()
        {
            return isWorking;
        }

        public void setWorking(bool working)
        {
            isWorking = working;
        }


        public double getMax_Size()
        {
            return max_size;
        }

        public void setMax_Size(double max_Count)
        {
            this.max_size = max_Count;
        }

        public double getTotal_Size()
        {
            return total_size;
        }

        public void setTotal_Size(double total_Size)
        {
            this.total_size = total_Size;
        }
    }
    public class GraphNode
    {
        public int from, to;
        public double weight;

        public GraphNode(int from, int to, double weight)
        {
            this.from = from;
            this.to = to;
            this.weight = weight;

        }
        public int getFrom()
        {
            return from;
        }
        public void setFrom(int from)
        {
            this.from = from;
        }
        public int getTo()
        {
            return to;
        }
        public void setTo(int to)
        {
            this.to = to;
        }
        public double getWeight()
        {
            return weight;
        }
        public void setWeight(double weight)
        {
            this.weight = weight;
        }
    }
    public class Graph
    {
        public int num_of_tops, num_of_weights;
        public List<List<int>> adj;
        public List<GraphNode> graph = new List<GraphNode>();
        public static List<NodeProcessing> nodeProcessing = new List<NodeProcessing>();
        public double[] Count_array;
        public bool[] isWorking;
        public double[,] matrix;
        public int[] tops_array_from;
        public Graph(int num_of_tops, int num_of_weights)
        {
            this.num_of_tops = num_of_tops;
            this.adj = new List<List<int>>(num_of_tops);
            this.num_of_weights = num_of_weights;
            Count_array = new double[this.num_of_tops];
            isWorking = new bool[this.num_of_weights];
            this.matrix = new double[this.num_of_tops, this.num_of_tops];
            tops_array_from = new int[this.num_of_tops];
            for (int i = 0; i < num_of_weights; i++)
            {
                isWorking[i] = true;
            }
            for (int i = 0; i < num_of_tops; i++)
            {
                adj.Add(new List<int>());
                tops_array_from[i] = 0;
                for (int j = 0; j < num_of_tops; j++)
                {
                    matrix[i, j] = 0;
                }
            }
        }
        private bool isCyclicUtil(int i, bool[] visited, bool[] recStack)
        {
            recStack[i] = true;
            List<int> children = adj.ToArray()[i];
            foreach (int c in children)
                if (recStack[c])
                {
                    return true;
                }
                else if (!visited[c] && isCyclicUtil(c, visited, recStack))
                {
                    return true;
                }
            recStack[i] = false;
            visited[i] = true;
            return false;
        }
        private void areOtherWaysNeedToBeBlocked(int i, int from)
        {
            if (adj.ToArray()[graph.ToArray()[i].getFrom() - 1].Count() == 0 && from != num_of_tops)
            {
                for (int k = num_of_weights - 1; k > 0; k--)
                {
                    if (graph.ToArray()[k].getTo() == graph.ToArray()[i].getFrom())
                    {
                        isWorking[k] = false;
                        areOtherWaysNeedToBeBlocked(k, graph.ToArray()[i].getFrom());
                    }
                }
            }
            else if (adj.ToArray()[graph.ToArray()[i].getFrom() - 1].Count() == 1 && from != graph.ToArray()[i].getFrom() /*&& from != num_of_tops*/ )
            {
                if (!isWorking[i])
                {
                    for (int k = num_of_weights - 1; k > 0; k--)
                    {
                        if (graph.ToArray()[k].getTo() == graph.ToArray()[i].getFrom() && isWorking[k])
                        {
                            isWorking[k] = false;
                            areOtherWaysNeedToBeBlocked(k, graph.ToArray()[i].getFrom());
                        }
                    }
                }
            }
        }
        public void isCyclic()
        {
            bool[] visited = new bool[num_of_tops];
            bool[] recStack = new bool[num_of_tops];
            for (int k = num_of_weights - 1; k > 0; k--)
            {
                if (graph.ToArray()[k].getFrom() == num_of_tops)
                {
                    isWorking[k] = false;
                }
            }
            fillAdj();
            for (int i = num_of_weights - 1; i > 0; i--)
            {
                if (graph.ToArray()[i].getFrom() > graph.ToArray()[i].getTo() && calcTops(i) != 1)
                {
                    foreach (int c in adj.ToArray()[graph.ToArray()[i].getTo() - 1])
                        if (graph.ToArray()[i].getFrom() - 1 == c)
                        {
                            BlockingOfNode(i);
                            break;
                        }
                }
                else if (graph.ToArray()[i].getFrom() > graph.ToArray()[i].getTo() && calcTops(i) == 1)
                {
                    if (isCyclicUtil(graph.ToArray()[i].getTo() - 1, visited, recStack))
                    {
                        BlockingOfNode(i);
                        areOtherWaysNeedToBeBlocked(i, (graph.ToArray()[i].getFrom()));
                    }
                }
            }
            for (int i = num_of_weights - 1; i > 0; i--)
            {
                if (graph.ToArray()[i].getFrom() > graph.ToArray()[i].getTo())
                {
                    if (isCyclicUtil(graph.ToArray()[i].getTo() - 1, visited, recStack) && isWorking[i])
                    {
                        if (isNodeNeedToBeBlocked(i, i, graph.ToArray()[i].getFrom(), graph.ToArray()[i].getTo()))
                        {
                            BlockingOfNode(i);
                        }
                        areOtherWaysNeedToBeBlocked(i, (graph.ToArray()[i].getFrom()));
                    }
                }
            }
            for (int i = 0; i < num_of_weights; i++)
            {
                bool[] visited1 = new bool[num_of_tops];
                bool[] recStack1 = new bool[num_of_tops];
                if (!isWorking[i] && graph.ToArray()[i].getTo() < graph.ToArray()[i].getFrom())
                {
                    int In = graph.ToArray()[i].getTo() - 1;
                    adj.ToArray()[graph.ToArray()[i].getFrom() - 1].Add(In);
                    if (!isCyclicUtil(graph.ToArray()[i].getTo() - 1, visited1, recStack1))
                        isWorking[i] = true;
                    else adj.ToArray()[graph.ToArray()[i].getFrom() - 1].Remove(In);
                }
            }
        }
        public bool isNodeNeedToBeBlocked(int i, int k, int from, int to)
        {
            if (graph.ToArray()[i].getTo() == from || (graph.ToArray()[i].getTo() == to && i != k))
            {
                return true;
            }
            if (graph.ToArray()[i].getTo() == num_of_tops)
            {
                return false;
            }
            for (int j = 0; j < num_of_weights; j++)
            {
                if (graph.ToArray()[j].getFrom() == graph.ToArray()[i].getTo() && isWorking[j])
                {
                    if (isNodeNeedToBeBlocked(j, k, from, to))
                        return true;
                }
            }
            return false;
        }
        public void BlockingOfNode(int i)
        {
            isWorking[i] = false;
            int In = graph.ToArray()[i].getTo() - 1;
            adj.ToArray()[graph.ToArray()[i].getFrom() - 1].Remove(In);
        }

        public void fillAdj()
        {
            for (int j = 0; j < num_of_weights; j++)
            {
                adj.ToArray()[graph.ToArray()[j].getFrom() - 1].Add(graph.ToArray()[j].getTo() - 1);
            }
        }
        public void maxFlow()
        {
            Console.WriteLine($"Максимальный поток из начальной в конечную вершины = {MaxFlow_Ford_Fulkerson.findMaxFlow(matrix, 0, num_of_tops - 1, num_of_tops):f5}\n");
        }
        private void FillTopsArr(int[] arr)
        {
            for (int i = 0; i < num_of_weights; i++)
            {
                arr[graph.ToArray()[i].getFrom() - 1] = 0;
            }
            for (int i = 0; i < num_of_weights; i++)
            {
                if (isWorking[i])
                {
                    arr[graph.ToArray()[i].getFrom() - 1]++;
                }
            }
        }
        public bool IsCountArrayFull()
        {
            for (int i = 0; i < num_of_tops - 1; i++)
            {
                if (Count_array[i] != 0)
                {
                    return true;
                }
            }
            return false;
        }
        public void OptimizeCount(double V)
        {
            isCyclic();
            FillTopsArr(tops_array_from);
            Count_array[0] = V;

            if (nodeProcessing.ToArray()[0].getMax_Size() < V)
            {
                Count_array[0] = nodeProcessing.ToArray()[0].getMax_Size();
            }
            for (int i = 0; i < num_of_weights; i++)
            {
                Optimize(i);
            }
            FillTopsArr(tops_array_from);
            maxFlow();
            nodeProcessing.ToArray()[0].setNumber_of_threads(1);
            nodeProcessing.ToArray()[0].setCount(V);
            nodeProcessing.ToArray()[0].setSum_of_time(0.05);
            printProcess();
            calcReliability();
        }
        public void printProcess()
        {
            double sum = 0;
            for (int i = 0; i < nodeProcessing.Count(); i++)
            {
                sum += nodeProcessing.ToArray()[i].getTimeProcessing();
                Console.WriteLine($"Время обработки : {nodeProcessing.ToArray()[i].getTimeProcessing():f10}\n");
            }
            sum = sum / num_of_tops;
            Console.WriteLine($"Cреднее время обработки = {sum:f5}\n");
        }
        public int findTop(int from)
        {
            for (int i = 0; i < num_of_weights; i++)
            {
                if (graph.ToArray()[i].getFrom() == from)
                {
                    return i;
                }
            }
            return 0;
        }
        public int calcTops(int i)
        {
            int k = 0;
            for (int j = 0; j < num_of_weights; j++)
            {
                if (graph.ToArray()[i].getFrom() == graph.ToArray()[j].getFrom() && isWorking[j])
                {
                    k++;
                }
            }
            return k;
        }
        public void calcReliability()
        {
            double k2 = 0;
            double p = 0;
            foreach (NodeProcessing c in nodeProcessing)
            {
                if (c.IsWorking())
                {
                    k2++;
                }
            }
            p = k2 / num_of_tops;
            Console.WriteLine($"Вероятность безотказной работы системы = {p:f5}\n");
        }
        public void Optimize(int i)
        {
            if (isWorking[i] && Count_array[graph.ToArray()[i].getFrom() - 1] != 0)
            {
                if (graph.ToArray()[i].getFrom() > graph.ToArray()[i].getTo())
                {
                    optimizeHelp(i);
                    int from = findTop(graph.ToArray()[i].getTo());
                    tops_array_from[graph.ToArray()[i].getTo() - 1] = calcTops(from);
                    for (int k = from; k < i; k++)
                    {
                        Optimize(k);
                    }
                }
                else
                {
                    optimizeHelp(i);

                }
            }
        }

        public void optimizeHelp(int i)
        {
            double Count;
            double before_queue = nodeProcessing.ToArray()[graph.ToArray()[i].getTo() - 1].getTotal_Size();
            Count = Count_array[graph.ToArray()[i].getFrom() - 1] / tops_array_from[graph.ToArray()[i].getFrom() - 1];
            nodeProcessing.ToArray()[graph.ToArray()[i].getTo() - 1].setTotal_Size((nodeProcessing.ToArray()[graph.ToArray()[i].getTo() - 1].getTotal_Size() + Count));
            if (nodeProcessing.ToArray()[graph.ToArray()[i].getTo() - 1].getTotal_Size() >= nodeProcessing.ToArray()[graph.ToArray()[i].getTo() - 1].getMax_Size())
            {
                nodeProcessing.ToArray()[graph.ToArray()[i].getTo() - 1].setWorking(false);
                isWorking[i] = false;
                for (int t = i + 1; t < num_of_weights; t++)
                {
                    if (graph.ToArray()[t].getTo() == graph.ToArray()[i].getTo() && isWorking[t])
                    {
                        isWorking[t] = false;
                        tops_array_from[graph.ToArray()[t].getFrom() - 1]--;
                    }
                }
                double Count_t = nodeProcessing.ToArray()[graph.ToArray()[i].getTo() - 1].getMax_Size() - before_queue;
                nodeProcessing.ToArray()[graph.ToArray()[i].getTo() - 1].setTotal_Size(nodeProcessing.ToArray()[graph.ToArray()[i].getTo() - 1].getMax_Size());
                matrix[graph.ToArray()[i].getFrom() - 1, graph.ToArray()[i].getTo() - 1] += Count_t;
                int k = nodeProcessing.ToArray()[graph.ToArray()[i].getTo() - 1].getNumber_of_threads() + 1;
                nodeProcessing.ToArray()[graph.ToArray()[i].getTo() - 1].setNumber_of_threads(k);
                nodeProcessing.ToArray()[graph.ToArray()[i].getTo() - 1].setSum_of_time(Count / graph.ToArray()[i].getWeight());
                nodeProcessing.ToArray()[graph.ToArray()[i].getTo() - 1].setCount(nodeProcessing.ToArray()[graph.ToArray()[i].getTo() - 1].getSize() + nodeProcessing.ToArray()[graph.ToArray()[i].getTo() - 1].getMax_Size());
                Count_t = checkIfOverload(Count_t, i, Count_array);
                Console.WriteLine($"from {graph.ToArray()[i].getFrom()} to {graph.ToArray()[i].getTo()}: {Count_t}");
                Count_array[graph.ToArray()[i].getFrom() - 1] -= Count_t;
                tops_array_from[graph.ToArray()[i].getFrom() - 1]--;
                Count_array[graph.ToArray()[i].getTo() - 1] += Count_t;
                nodeProcessing.ToArray()[graph.ToArray()[i].getTo() - 1].calcTime();
                nodeProcessing.ToArray()[graph.ToArray()[i].getTo() - 1].setNumber_of_threads(0);
                nodeProcessing.ToArray()[graph.ToArray()[i].getTo() - 1].setSum_of_time(0);
                FillTopsArr(tops_array_from);
                k = findTop(graph.ToArray()[i].getFrom());
                while (graph.ToArray()[k].getFrom() == graph.ToArray()[i].getFrom())
                {
                    if (k == i)
                    {
                        k++;
                    }
                    else
                    {
                        Optimize(k);
                        k++;
                    }

                }
            }
            else
            {
                matrix[graph.ToArray()[i].getFrom() - 1, graph.ToArray()[i].getTo() - 1] += Count;
                int k = nodeProcessing.ToArray()[graph.ToArray()[i].getTo() - 1].getNumber_of_threads() + 1;
                nodeProcessing.ToArray()[graph.ToArray()[i].getTo() - 1].setNumber_of_threads(k);
                nodeProcessing.ToArray()[graph.ToArray()[i].getTo() - 1].setSum_of_time(Count / graph.ToArray()[i].getWeight());
                nodeProcessing.ToArray()[graph.ToArray()[i].getTo() - 1].setCount(nodeProcessing.ToArray()[graph.ToArray()[i].getTo() - 1].getSize() + Count);
                Count = checkIfOverload(Count, i, Count_array);
                Console.WriteLine($"from {graph.ToArray()[i].getFrom()} to {graph.ToArray()[i].getTo()}: {Count}");
                Count_array[graph.ToArray()[i].getTo() - 1] += Count;
                Count_array[graph.ToArray()[i].getFrom() - 1] -= Count;
                tops_array_from[graph.ToArray()[i].getFrom() - 1]--;
                nodeProcessing.ToArray()[graph.ToArray()[i].getTo() - 1].calcTime();
                nodeProcessing.ToArray()[graph.ToArray()[i].getTo() - 1].setNumber_of_threads(0);
                nodeProcessing.ToArray()[graph.ToArray()[i].getTo() - 1].setSum_of_time(0);
            }
        }

        public double checkIfOverload(double Count, int i, double[] arr)
        {
            while (Count > graph.ToArray()[i].getWeight())
            {
                int k = nodeProcessing.ToArray()[graph.ToArray()[i].getTo() - 1].getNumber_of_threads() + 1;
                nodeProcessing.ToArray()[graph.ToArray()[i].getTo() - 1].setNumber_of_threads(k);
                nodeProcessing.ToArray()[graph.ToArray()[i].getTo() - 1].setSum_of_time(nodeProcessing.ToArray()[graph.ToArray()[i].getTo() - 1].getSum_of_time() + 1 / graph.ToArray()[i].getWeight());
                Count -= graph.ToArray()[i].getWeight();
                Count_array[graph.ToArray()[i].getFrom() - 1] -= graph.ToArray()[i].getWeight();
                Console.WriteLine($"from {graph.ToArray()[i].getFrom()} to {graph.ToArray()[i].getTo()}: {graph.ToArray()[i].getWeight()}");
                arr[graph.ToArray()[i].getTo() - 1] += graph.ToArray()[i].getWeight();
            }
            return Count;
        }
        public void addGraphNode(int from, int to, double weight)
        {
            graph.Add(new GraphNode(from, to, weight));
        }

        public void addNodeParameter(bool isWorking, double max_size)
        {
            nodeProcessing.Add(new NodeProcessing(isWorking, max_size));
        }
        public void deleteGraphNode(int i)
        {
            graph.RemoveAt(i);
        }
        public List<GraphNode> getGraph()
        {
            return graph;
        }
        public void setGraph(List<GraphNode> graph)
        {
            this.graph = graph;
        }
        public void printGraph()
        {
            for (int i = 0; i < num_of_weights; i++)
            {
                Console.WriteLine($"{graph.ToArray()[i].getFrom()} o---------o {graph.ToArray()[i].getTo()} " +
                    $"пропускная способность канала: {graph.ToArray()[i].getWeight():f3}\n");
            }
        }
        public int getNum_of_tops()
        {
            return num_of_tops;
        }

        public void setNum_of_tops(int num_of_tops)
        {
            this.num_of_tops = num_of_tops;
        }

        public int getNum_of_weights()
        {
            return num_of_weights;
        }

        public void setNum_of_weights(int num_of_weights)
        {
            this.num_of_weights = num_of_weights;
        }

        public int[,] getMatrix()
        {
            int[,] Matrix = new int[num_of_tops, num_of_tops];
            for (int i = 0; i < num_of_weights; i++)
            {
                Matrix[graph[i].getFrom() - 1, graph[i].getTo() - 1] = 1;
            }
            return Matrix;
        }
    }
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Graphs());
        }
    }
}
