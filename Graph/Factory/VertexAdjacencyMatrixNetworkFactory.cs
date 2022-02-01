using Graph.Entity;
using Graph.Parser;

namespace Graph.Factory;

public class VertexAdjacencyMatrixNetworkFactory : IVertexAdjacencyMatrixNetworkFactory
{
    private readonly IMatrixGraphParser _vertexMatrixParser;

    public VertexAdjacencyMatrixNetworkFactory(IMatrixGraphParser vertexMatrixParser)
    {
        _vertexMatrixParser = vertexMatrixParser;
    }
    
    public IMatrixNetwork Create()
    {
        var matrix = _vertexMatrixParser.Parse();
        var sourceSinkIndex = GetAndVerifySourceAndSink(matrix);
        
        var network = new VertexAdjacencyMatrixNetwork(matrix);
        network.SourceIndex = sourceSinkIndex.sourceIndex;
        network.SinkIndex = sourceSinkIndex.sinkIndex;

        return network;
    }

    private (int sourceIndex, int sinkIndex) GetAndVerifySourceAndSink(double[,] matrix)
    {
        var sources = FindAllVertexesWithoutIncomingEdges(matrix);
        var sinks = FindAllVertexesWithoutOutgoingEdges(matrix);

        if (sources.Count is 0 or > 1 && sinks.Count is 0 or > 1)
            throw new InvalidDataException("incorrect number of sources and sinks");

        return (sources[0], sinks[0]);
    }

    private IList<int> FindAllVertexesWithoutIncomingEdges(double[,] matrix)
    {
        var list = new List<int>();

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (!IsIncomingEdgesExist(matrix, i))
                list.Add(i);
        }

        return list;
    }
    
    private IList<int> FindAllVertexesWithoutOutgoingEdges(double[,] matrix)
    {
        var list = new List<int>();

        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            if (!IsOutgoingEdgesExist(matrix, i))
                list.Add(i);
        }

        return list;
    }

    private bool IsIncomingEdgesExist(double[,] matrix, int vertexIndex)
    {
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            if (!double.IsInfinity(matrix[i, vertexIndex])) return true;
        }

        return false;
    }
    
    private bool IsOutgoingEdgesExist(double[,] matrix, int vertexIndex)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (!double.IsInfinity(matrix[vertexIndex, i])) return true;
        }

        return false;
    }
}