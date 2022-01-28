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
        Verify(matrix);
        
        return new VertexAdjacencyMatrixNetwork(matrix);
    }

    private void Verify(double[,] matrix)
    {
        //check for only one source and sink
    }
}