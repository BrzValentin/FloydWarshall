using Graph.Entity;

namespace GraphAlgorithm.ShortestPath.Dijkstra;

public class Dijkstra : IAlgorithm
{
    public Algorithm Algorithm => Algorithm.Dijkstra;
    
    public void Run(IMatrixGraph graph)
    {
        var n = graph.Size;
        var distance = new int [n];
        var parents = new int [n];
        var visited = new bool [n];

        PreInitialization(distance, parents);

        for (int i = 0; i < n; i++)
        {
            int index = LastNotVisitedMinimum(distance, visited);
            visited[index] = true;

            for (int j = 0; j < n; j++)
            {
                var posible = distance[index] + graph.Matrix[index, j];
                if (!visited[j] && graph.Matrix[index, j] != int.MaxValue && posible < distance[j])
                {
                    distance[j] = posible;
                    parents[j] = index;
                }
            }
        }
    }

    private int LastNotVisitedMinimum(int[] distance, bool[] visited)
    {
        int minimum = int.MaxValue;
        int minimumIndex = -1;

        for (int i = 0; i < distance.Length; i++)
            if (!visited[i] && distance[i] <= minimum)
            {
                minimumIndex = i;
                minimum = distance[i];
            }

        return minimumIndex;
    }

    private void PreInitialization(int[] distance, int[] parents)
    {
        for (int i = 1; i < distance.Length; i++)
        {
            distance[i] = int.MaxValue;
        }

        for (int i = 0; i < parents.Length; i++)
        {
            parents[i] = -1;
        }
    }
}