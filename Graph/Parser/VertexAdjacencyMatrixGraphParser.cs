namespace Graph.Parser;

public class VertexAdjacencyMatrixGraphParser : VertexAdjacencyMatrixGraphParserBase
{
    public VertexAdjacencyMatrixGraphParser(string path) : base(path)
    {
    }

    protected override IList<int> ConvertLine(string line)
    {
        return Utils.ConvertToInts(line);
    }
}