namespace GraphAlgorithm.Network.PERT;

public class PERTNetworkAnalyzer
{
    private readonly double[,] _matrix;
    private readonly int[,] _parents;

    public PERTNetworkAnalyzer(double[,] matrix, int[,] parents)
    {
        _matrix = matrix;
        _parents = parents;
    }
}