namespace GraphAlgorithm.ShortestPath.FloydWarshall;

public class FloydWarshallResultAnalyzer
{
    private readonly double[,] _matrix;
    private readonly int[,] _parents;

    public FloydWarshallResultAnalyzer(double[,] matrix, int[,] parents)
    {
        _matrix = matrix;
        _parents = parents;
    }

    public void ShowDistancesMatrix()
    {
        Console.WriteLine();
        Console.WriteLine("Distance matrix:");
        for (int i = 0; i < _matrix.GetLength(0); i++)
        {
            for (int j = 0; j < _matrix.GetLength(1); j++)
            {
                Console.Write($"v[{i+1}, {j+1}]={_matrix[i, j]} ");
            }
            Console.WriteLine();
        }
    }

    public void ShowParentMatrix()
    {
        Console.WriteLine();
        Console.WriteLine("Parent matrix:");
        for (int i = 0; i < _parents.GetLength(0); i++)
        {
            for (int j = 0; j < _parents.GetLength(1); j++)
            {
                Console.Write($"{_parents[i, j] + 1} ");
            }
            Console.WriteLine();
        }
    }

    public void ShowPath(int from, int to)
    {
        Console.WriteLine();
        Console.WriteLine($"Shortest path from {from} to {to}:");
        if (_parents[from - 1, to - 1] == 0 && from != 1 || from == to)
        {
            Console.Write("No path");
            return;
        }
            
        Console.Write($"{to} ");
        int newVert = -1;
        for (int i = to - 1; i != from - 1 && newVert != 0; i = newVert)
        {
            newVert = _parents[from - 1, i];
            Console.Write($"{newVert + 1} ");
        }
    }

    public void ShowPathFromAnyToAny()
    {
        for (int i = 0; i < _parents.GetLength(0); i++)
        {
            for (int j = 0; j < _parents.GetLength(1); j++)
            {
                ShowPath(i + 1, j + 1);
            }
        }
    }
}