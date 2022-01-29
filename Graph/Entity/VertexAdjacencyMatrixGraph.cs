namespace Graph.Entity;

public class VertexAdjacencyMatrixGraph : IMatrixGraph
{
    private int _size;
    private int _capacity;
    public double[,] Matrix { get; }
    public int Size => _size;
    public int Сapacity => _capacity;

    public VertexAdjacencyMatrixGraph(double[,] matrix)
    {
        Matrix = matrix;
        _size = matrix.GetLength(0);
        _capacity = CalculateCapacity();
    }

    private int CalculateCapacity()
    {
        return 1;
    }
}