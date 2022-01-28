using Graph;
using Graph.Entity;

namespace GraphAlgorithm.ShortestPath.FloydWarshall;

public class FloydWarshall
{
    public Algorithm Algorithm => Algorithm.FloydWarshall;

    public FloydWarshallResult Run(IMatrixGraph graph)
    {
        int n = graph.Size;
        int[,] parents = new int[n,n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                parents[i, j] = i;
            }
        }
        
        var b = Utils.Copy(graph.Matrix);
        for (int k = 0; k < n; k++)
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    if (b[i, k] + b[k, j] < b[i, j])
                    {
                        b[i, j] = b[i, k] + b[k, j];
                        parents[i, j] = parents[k, j];
                    }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (double.IsInfinity(b[i, j]))
                    parents[i, j] = 0;
            }
        }

        return new FloydWarshallResult { Dictances = Utils.Copy(b), Parents = Utils.Copy(parents) };
    }
}