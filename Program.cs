namespace Basic_Graph
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomGraph graph = new CustomGraph();

            //Adding Vertices
            graph.AddVertex("A");
            graph.AddVertex("B");
            graph.AddVertex("C");
            graph.AddVertex("D");

            //Adding Edges
            graph.AddEdge("A", "B");
            graph.AddEdge("B", "C");
            graph.AddEdge("C", "D");
            graph.AddEdge("D", "A");

            List<String> neighbors = graph.GetNeighbor("A");
            Console.WriteLine("Neighbor of A: " + string.Join(" ," , neighbors));

            //Printing the Graph
            Dictionary<String, List<String>> graphStructure = graph.PrintGraph();
            foreach(var vertex in graphStructure) 
            {
                Console.WriteLine("Vertex: " + vertex.Key);
                Console.WriteLine("Neighbors: " + string.Join(", " , vertex.Value));
            }
        }
    }
}