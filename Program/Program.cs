// See https://aka.ms/new-console-template for more information

using Graph;
using Graph.Factory;
using Graph.Parser;

var parser = new VertexAdjacencyMatrixWithInfinityGraphParser($"{Utils.RelativePathToResFile}\\VertexAdjacencyMatrixGraphWithInfinity.txt");
var factory = new VertexAdjacencyMatrixGraphFactory(parser);
var graph = factory.Create();
Console.WriteLine("Hello, World!");
