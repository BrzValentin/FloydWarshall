namespace Graph.Parser;

public class VertexAdjacencyMatrixWithInfinityGraphParser : VertexAdjacencyMatrixGraphParserBase
{
    public VertexAdjacencyMatrixWithInfinityGraphParser(string path) : base(path)
    {
    }

    protected override IList<int> ConvertLine(string line)
    {
        return line.Split(' ').Select(i => i == "I" ? int.MaxValue : int.Parse(i)).ToList();
    }
}