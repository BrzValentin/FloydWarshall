namespace Graph.Parser;

public class VertexAdjacencyMatrixGraphParser : IMatrixGraphParser
{
    private readonly string _path;

    public VertexAdjacencyMatrixGraphParser(string path)
    {
        _path = path;
    }

    public int[,] Parse()
    {
        using var sr = new StreamReader(_path, System.Text.Encoding.Default);
        string line;
        List<List<int>> matrix = new List<List<int>>();
        while ((line = sr.ReadLine()) != null)
        {
            matrix.Add(Utils.ConvertToInts(line));
        }

        return Utils.ConvertToArray(matrix);
    }
}