namespace Graph.Parser;

public class VertexAdjacencyMatrixWithInfinityGraphParser : VertexAdjacencyMatrixGraphParserBase
{
    public VertexAdjacencyMatrixWithInfinityGraphParser(string path) : base(path)
    {
    }

    protected override IList<double> ConvertLine(string line)
    {
        return line.Split(' ').Select(i => i == "I" ? double.PositiveInfinity : double.Parse(i)).ToList();
    }
}