using System;

namespace DFS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Breadth First Search...");

            Graph g = new Graph(4);
            g.AddEdge(0, 1); //0 vertex => 1
            g.AddEdge(0, 2); //0 vertex => 2
            g.AddEdge(1, 2); //1 vertex => 2
            g.AddEdge(2, 0); //2 vertex => 0
            g.AddEdge(2, 3); //2 vertex => 3
            g.AddEdge(3, 3); //3 vertex => 3

            // Graph Representation
            //  0-- 1
            //   \ /
            //    2--3

            Console.WriteLine(
                "Following is Depth First Traversal "
                + "(starting from vertex 2)");

            g.DFS(1);
        }
    }
}
