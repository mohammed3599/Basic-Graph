using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Graph
{
    internal class CustomGraph
    {
        private Dictionary<String, List<String>> graph;
        public CustomGraph() 
        {
            graph = new Dictionary<String, List<String>>();
        }
        public void AddVertex(String vertex) 
        {
            if(!graph.ContainsKey(vertex))
            {
                graph[vertex] = new List<String>();
            }
        }
        public void AddEdge(String vertex1, String vertex2) 
        {
            if (graph.ContainsKey(vertex1) && graph.ContainsKey(vertex2)) 
            {
                graph[vertex1].Add(vertex2);
                graph[vertex2].Add(vertex1);
            }
        }
        public List<String> GetNeighbor(String vertex) 
        {
            if (graph.ContainsKey(vertex))
            {
                return graph[vertex];
            }

            return new List<string> ();
        }
        public List<String> GetVertices()
        {
            List<String> vertices = new List<String>(graph.Keys);
            return vertices;
        }
        public Dictionary<String, List<String>> PrintGraph() 
        {
            return graph;
        }


        //Depth First Search
        public void DFS(String startVertex)
        {
            HashSet<String> visited = new HashSet<String>();
            DFSRecursive(startVertex, visited);
        }

        //DFS Recursive
        public void DFSRecursive(String currentVertex, HashSet<String> visited)
        {
            Console.WriteLine(currentVertex + " ");
            foreach (String vertex in graph[currentVertex])
            {
                if (!visited.Contains(vertex))
                {
                    DFSRecursive(vertex, visited);
                }
            }
        }

        //DFS with Stack
        public void DFSWithStack(String startVertex)
        {
            HashSet<String> visited = new HashSet<String>();
            Stack<String> stack = new Stack<String>();

            stack.Push(startVertex);

            while (stack.Count > 0)
            {
                String currentVertex = stack.Pop();
                if (!visited.Contains(currentVertex))
                {
                    Console.WriteLine(currentVertex + " ");
                    visited.Add(currentVertex);
                }

                foreach (String neighborVertex in graph[currentVertex])
                {
                    if (!visited.Contains(neighborVertex))
                    {
                        stack.Push(neighborVertex);
                    }
                }
            }
        }
    }
}
