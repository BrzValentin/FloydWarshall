// See https://aka.ms/new-console-template for more information


using Graph.Entity;
using Graph.Factory;
using Graph.Parser;

var parser = new VertexAdjacencyMatrixGraphParser("C:\\study\\Graph\\Labs\\FloydWarshall\\Graph\\Res\\VertexAdjacencyMatrixGraph.txt");
var factory = new VertexAdjacencyMatrixGraphFactory(parser);
var graph = factory.Create();
Console.WriteLine("Hello, World!");
