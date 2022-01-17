// See https://aka.ms/new-console-template for more information

using Graph;
using Graph.Factory;
using Graph.Parser;
using GraphAlgorithm;
using GraphAlgorithm.ShortestPath.Dijkstra;

var parser = new VertexAdjacencyMatrixWithInfinityGraphParser($"{Utils.RelativePathToResFile}\\VertexAdjacencyMatrixGraphWithInfinity.txt");
var factory = new VertexAdjacencyMatrixGraphFactory(parser);
var graph = factory.Create();

IAlgorithm dijkstra = new Dijkstra();
dijkstra.Run(graph);
Console.WriteLine("Hello, World!");
