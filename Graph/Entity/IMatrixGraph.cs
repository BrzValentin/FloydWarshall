namespace Graph.Entity;

public interface IMatrixGraph
{
    int[,] Matrix { get; }
    int Size { get; }
    int Сapacity { get; }
}