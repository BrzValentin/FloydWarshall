namespace Graph.Entity;

public class VertexAdjacencyMatrixNetwork : VertexAdjacencyMatrixGraph, IMatrixNetwork
{
    public int SourceIndex { get; set; }

    public int SinkIndex { get; set; }

    public VertexAdjacencyMatrixNetwork(double[,] matrix) : base(matrix)
    {
    }
}