using Graph.Entity;

namespace GraphAlgorithm.ShortestPath.Dijkstra;

public class Dijkstra : IAlgorithm
{
    public Algorithm Algorithm => Algorithm.Dijkstra;
    
    public void Run(IMatrixGraph graph)
    {
        var n = graph.Size;
        var distance = new double [n];
        var parents = new int [n];
        var visited = new bool [n];

        PreInitialize(distance, parents);

        for (int i = 0; i < n; i++)
        {
            int index = GetLastNotVisitedMinimum(distance, visited);
            visited[index] = true;

            for (int j = 0; j < n; j++)
            {
                var possible = distance[index] + graph.Matrix[index, j];
                if (!visited[j] && !double.IsInfinity(graph.Matrix[index, j]) && possible < distance[j])
                {
                    distance[j] = possible;
                    parents[j] = index + 1;
                }
            }
        }
    }

    private int GetLastNotVisitedMinimum(double[] distance, bool[] visited)
    {
        double minimum = double.MaxValue;
        int minimumIndex = -1;

        for (int i = 0; i < distance.Length; i++)
            if (!visited[i] && distance[i] <= minimum)
            {
                minimumIndex = i;
                minimum = distance[i];
            }

        return minimumIndex;
    }

    private void PreInitialize(double[] distance, int[] parents)
    {
        for (int i = 1; i < distance.Length; i++)
        {
            distance[i] = Double.PositiveInfinity;
        }

        for (int i = 0; i < parents.Length; i++)
        {
            parents[i] = -1;
        }
    }
}