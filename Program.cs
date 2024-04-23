// See https://aka.ms/new-console-template for more information

using Satsuma;
using Unchase.Satsuma.Core;

class Graph
{
    void CreateGraph()
    {
        CustomGraph graph = new CustomGraph();

        Satsuma.Node a = graph.AddNode();
        Satsuma.Node b = graph.AddNode();
        Satsuma.Node c = graph.AddNode();    

        Satsuma.Arc ab = graph.AddArc(a, b, Directedness.Undirected);
        Satsuma.Arc bc = graph.AddArc(b, c, Directedness.Undirected);

    }


    static void Main(string[] args)
    {

        Console.WriteLine("Hello, World!");
        Graph graph = new Graph();
        graph.CreateGraph();
    }
}
