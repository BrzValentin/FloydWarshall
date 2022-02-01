using Graph.Entity;

namespace GraphAlgorithm.Network.PERT;

public class PERTNetworkAnalyzer
{
    private readonly IMatrixNetwork _network;
    private readonly double[,] _distances;
    private readonly int[,] _parents;

    public PERTNetworkAnalyzer(IMatrixNetwork network, int[,] parents, double[,] distances)
    {
        _network = network;
        _distances = distances;
        _parents = parents;
    }

    public void ShowEventMomentTime()
    {
        Console.WriteLine();
        Console.WriteLine("Event moment time:");
        for (int j = _network.SourceIndex; j <= _network.SinkIndex; j++)
        {
            Console.Write($"v[{j + 1}]={Math.Abs(_distances[_network.SourceIndex, j])} ");
        }
    }

    public void ShowPath(int from, int to)
    {
        Console.WriteLine();
        Console.WriteLine($"Critical path from {from} to {to}:");
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

    public void ShowDelays()
    {
        Console.WriteLine();
        Console.WriteLine("Delays");

        for (int i = 0; i < _network.Matrix.GetLength(0); i++)
        {
            for (int j = 0; j < _network.Matrix.GetLength(1); j++)
            {
                if (double.IsInfinity(_network.Matrix[i, j]) ||
                    double.IsInfinity(_distances[_network.SourceIndex, j]) ||
                    double.IsInfinity(_distances[_network.SourceIndex, i]))
                    continue;

                Console.Write(
                    $"d[{i + 1}, {j + 1}]={_distances[_network.SourceIndex, j] - _distances[_network.SourceIndex, i] - _network.Matrix[i, j]} ");
            }
        }
    }

    public void ShowAllPathsFromSourceToSink()
    {
        for (int i = _network.SourceIndex; i <= _network.SinkIndex; i++)
        {
            ShowPath(_network.SourceIndex + 1, i + 1);
        }
    }
}