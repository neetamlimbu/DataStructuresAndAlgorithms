using System;
using System.Collections.Generic;

namespace DFS
{
    //Graph using adjacency lists
    public class Graph
    {
        private int v; //No. of vertices
        private List<int>[] adj; //Adjacency list of array of int

        public Graph(int vertices)
        {
            v = vertices;
            adj = new List<int>[vertices];
            for (int i = 0; i < vertices; i++)
            {
                adj[i] = new List<int>();
            }
        }

        public void AddEdge(int v, int w)
        {
            adj[v].Add(w); //Add w to v's list
        }

        private void VisitNode(int v, bool[] visited)
        {
            // Mark the current node as visited and print it
            visited[v] = true;
            Console.Write(v + " ");

            // Recur for all the vertices adjacent to this vertex
            foreach (int vertex in adj[v])
            {
                if (!visited[vertex])
                {
                    VisitNode(vertex, visited);
                }
            }
        }

        public void DFS(int vertex)
        {
            bool[] visited = new bool[v];

            // Call the recursive helper function to print DFS traversal starting from all vertices one by one
            // Recursion calls will act like a stack ideal for DFS
            VisitNode(vertex, visited);
        }
    }
}