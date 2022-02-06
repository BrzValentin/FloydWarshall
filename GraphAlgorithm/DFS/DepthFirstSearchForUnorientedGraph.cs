using Graph.Entity;

namespace GraphAlgorithm.DFS;

public class DepthFirstSearchForUnorientedGraph
{
    private readonly IMatrixGraph _matrixGraph;

    public DepthFirstSearchForUnorientedGraph(IMatrixGraph matrixGraph)
    {
        _matrixGraph = matrixGraph;
    }

    public DepthFirstSearchResult Run()
    {
        Console.WriteLine();
        
        var result = new DepthFirstSearchResult(_matrixGraph.Size);
        DFS(0, result);
        return result;
    }

    private void DFS(int vertexIndex, DepthFirstSearchResult depthFirstSearchResult)
    {
        depthFirstSearchResult.Visited[vertexIndex] = true;

        for (int i = 0; i < _matrixGraph.Matrix.GetLength(1); i++)
        {
            var elem = _matrixGraph.Matrix[vertexIndex, i];
            if (depthFirstSearchResult.Visited[i] || elem == 0 || double.IsInfinity(elem)) continue;
            DFS(i, depthFirstSearchResult);
        }
    }
}