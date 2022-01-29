namespace Graph.Entity;

public interface IMatrixGraph
{
    double[,] Matrix { get; }
    int Size { get; }
    int Сapacity { get; }
}