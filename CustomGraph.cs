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
    }
}
