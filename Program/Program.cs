// See https://aka.ms/new-console-template for more information

using Graph;
using Graph.Factory;
using Graph.Parser;
using GraphAlgorithm.ShortestPath.FloydWarshall;

var parser = new VertexAdjacencyMatrixWithInfinityGraphParser($"{Utils.RelativePathToResFile}\\VertexAdjacencyMatrixGraphNetwork.txt");
var factory = new VertexAdjacencyMatrixGraphFactory(parser);
var graph = factory.Create();

var result = new FloydWarshall().Run(graph);
var analyzer = new FloydWarshallResultAnalyzer(result.Dictances, result.Parents);
analyzer.ShowParentMatrix();
analyzer.ShowDistancesMatrix();
analyzer.ShowPathFromAnyToAny();
