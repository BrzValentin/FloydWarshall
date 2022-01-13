using Graph.Entity;
using Graph.Parser;

namespace Graph.Factory;

public class VertexAdjacencyMatrixGraphFactory : IMatrixGraphFactory
{
    private readonly IMatrixGraphParser _vertexMatrixParser;

    public VertexAdjacencyMatrixGraphFactory(IMatrixGraphParser vertexMatrixParser)
    {
        _vertexMatrixParser = vertexMatrixParser;
    }

    public IMatrixGraph Create()
    {
        var matrix = _vertexMatrixParser.Parse();
        return new VertexAdjacencyMatrixGraph(matrix);
    }
}