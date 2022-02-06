namespace GraphAlgorithm.DFS;

public class DepthFirstSearchResult
{
    public  bool[] Visited;

    public DepthFirstSearchResult(int vertexCount)
    {
        Visited = new bool[vertexCount];
    }
}