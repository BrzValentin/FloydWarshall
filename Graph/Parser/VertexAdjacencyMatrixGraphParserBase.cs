namespace Graph.Parser;

public abstract class VertexAdjacencyMatrixGraphParserBase : IMatrixGraphParser
{
    private readonly string _path;

    protected VertexAdjacencyMatrixGraphParserBase(string path)
    {
        _path = path;
    }

    public double[,] Parse()
    {
        using var sr = new StreamReader(_path, System.Text.Encoding.Default);
        string line;
        IList<IList<double>> matrix = new List<IList<double>>();
        while ((line = sr.ReadLine()) != null)
        {
            matrix.Add(ConvertLine(line));
        }

        return Utils.ConvertToArray(matrix);
    }

    protected abstract IList<double> ConvertLine(string line);
}