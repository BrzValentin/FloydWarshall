namespace Graph.Entity;

public class VertexAdjacencyMatrixNetwork : VertexAdjacencyMatrixGraph, IMatrixNetwork
{
    public (int, int) SourceIndex { get; set; }

    public (int, int) SinkIndex { get; set; }

    public VertexAdjacencyMatrixNetwork(double[,] matrix) : base(matrix)
    {
    }
}