using Graph;
using Graph.Entity;
using GraphAlgorithm.ShortestPath.FloydWarshall;

namespace GraphAlgorithm.Network.PERT;

public class PERTNetworkAnalyzerFactory
{
    private readonly FloydWarshall _floydWarshallAlg;
    private readonly IMatrixNetwork _matrixNetwork;

    public PERTNetworkAnalyzerFactory(FloydWarshall floydWarshallAlg, IMatrixNetwork matrixNetwork)
    {
        _floydWarshallAlg = floydWarshallAlg;
        _matrixNetwork = matrixNetwork;
    }

    public PERTNetworkAnalyzer Create()
    {
        _matrixNetwork.ReverseSignWithoutInfinity();
        var result = _floydWarshallAlg.Run(_matrixNetwork);
        Utils.ReverseSignWithoutInfinity(result.Distances);

        _matrixNetwork.ReverseSignWithoutInfinity();
        return new PERTNetworkAnalyzer(_matrixNetwork, result.Parents, result.Distances);
    }
}