namespace Graph.Parser;

public abstract class VertexAdjacencyMatrixGraphParserBase : IMatrixGraphParser
{
    private readonly string _path;

    protected VertexAdjacencyMatrixGraphParserBase(string path)
    {
        _path = path;
    }

    public int[,] Parse()
    {
        using var sr = new StreamReader(_path, System.Text.Encoding.Default);
        string line;
        IList<IList<int>> matrix = new List<IList<int>>();
        while ((line = sr.ReadLine()) != null)
        {
            matrix.Add(ConvertLine(line));
        }

        return Utils.ConvertToArray(matrix);
    }

    protected abstract IList<int> ConvertLine(string line);
}