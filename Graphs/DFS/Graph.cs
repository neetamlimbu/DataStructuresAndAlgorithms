using System;
using System.Collections.Generic;

namespace DFS
{
    //Graph using adjacency lists
    public class Graph
    {
        private int v; //No. of vertices
        private List<int>[] adj; //Adjacency list of array of int

        public Graph(int noOfVertices)
        {
            v = noOfVertices;
            adj = new List<int>[noOfVertices];

            for (int i = 0; i < noOfVertices; i++)
            {
                adj[i] = new List<int>();
            }
        }

        public void AddEdge(int vertex, int weight)
        {
            adj[vertex].Add(weight); //Add weight to vertex list
        }

        private void VisitNode(int startVertex, bool[] visited)
        {
            // Mark the current node as visited and print it
            visited[startVertex] = true;
            Console.Write(startVertex + " ");

            // Recur for all the vertices adjacent to this vertex
            foreach (int vertex in adj[startVertex])
            {
                if (!visited[vertex])
                {
                    VisitNode(vertex, visited);
                }
            }
        }

        public void DFS(int startVertex)
        {
            bool[] visited = new bool[v];

            // Call the recursive helper function to print DFS traversal starting from all vertices one by one
            // Recursion calls will act like a stack ideal for DFS
            VisitNode(startVertex, visited);
        }
    }
}