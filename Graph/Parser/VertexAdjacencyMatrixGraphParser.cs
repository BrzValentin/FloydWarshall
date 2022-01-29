namespace Graph.Parser;

public class VertexAdjacencyMatrixGraphParser : VertexAdjacencyMatrixGraphParserBase
{
    public VertexAdjacencyMatrixGraphParser(string path) : base(path)
    {
    }

    protected override IList<double> ConvertLine(string line)
    {
        return Utils.ConvertToDouble(line);
    }
}