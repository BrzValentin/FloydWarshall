// See https://aka.ms/new-console-template for more information

using Graph;
using Graph.Factory;
using Graph.Parser;
using GraphAlgorithm.Network.PERT;
using GraphAlgorithm.ShortestPath.FloydWarshall;

var parser = new VertexAdjacencyMatrixWithInfinityGraphParser($"{Utils.RelativePathToResFile}\\VertexAdjacencyMatrixGraphNetwork.txt");

var factory = new VertexAdjacencyMatrixGraphFactory(parser);
var graph = factory.Create();
var floydWarshallAlg = new FloydWarshall();
var floydWarshallResult = floydWarshallAlg.Run(graph);
var floydWarshallResultAnalyzer = new FloydWarshallResultAnalyzer(floydWarshallResult.Distances, floydWarshallResult.Parents);
floydWarshallResultAnalyzer.ShowParentMatrix();
floydWarshallResultAnalyzer.ShowDistancesMatrix();
floydWarshallResultAnalyzer.ShowPathFromAnyToAny();

var networkFactory = new VertexAdjacencyMatrixNetworkFactory(parser);
var network = networkFactory.Create();
var networkAnalyzerFactory = new PERTNetworkAnalyzerFactory(floydWarshallAlg, network);
var networkAnalyzer = networkAnalyzerFactory.Create();