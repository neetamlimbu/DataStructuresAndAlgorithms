using System;
using System.Collections.Generic;
using System.Linq;

namespace BFS
{
    public class Graph
    {
        private int v; //No. of vertices
        private LinkedList<int>[] adj; //Adjacency Lists

        public Graph(int noOfVertices)
        {
            v = noOfVertices;
            adj = new LinkedList<int>[v];

            for (int i = 0; i < adj.Length; i++)
            {
                adj[i] = new LinkedList<int>();
            }
        }

        //Add an edge into the graph
        public void AddEdge(int vertex, int weight)
        {
            adj[vertex].AddLast(weight);
        }

        private void VisitVertex(int startVertex, bool[] visited)
        {
            //Create a queue for BFS
            LinkedList<int> queue = new LinkedList<int>();

            //Mark the current node as visited and enqueue it
            visited[startVertex] = true;
            queue.AddLast(startVertex);

            while (queue.Any())
            {
                //Dequeue a vertex from queue and print it
                startVertex = queue.First();
                Console.Write(startVertex + " ");
                queue.RemoveFirst();

                //Get all adjacent vertices of the dequeued start vertex
                //If a adjacent has not been visited, then mark it visited and enqueue it
                LinkedList<int> list = adj[startVertex];

                foreach (var val in list)
                {
                    if (!visited[val])
                    {
                        visited[val] = true;
                        queue.AddLast(val);
                    }
                }
            }
        }

        public void BFS(int startVertex)
        {
            bool[] visited = new bool[v];
            VisitVertex(startVertex, visited);
        }
    }
}