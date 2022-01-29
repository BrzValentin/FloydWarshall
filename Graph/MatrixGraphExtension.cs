using Graph.Entity;

namespace Graph;

public static class MatrixGraphExtension
{
    public static void ReverseSignWithoutInfinity(this IMatrixGraph graph)
    {
        for (int i = 0; i < graph.Matrix.GetLength(0); i++)
        {
            for (int j = 0; j < graph.Matrix.GetLength(1); j++)
            {
                if (double.IsInfinity(graph.Matrix[i, j])) continue;
                graph.Matrix[i, j] *= -1;
            }
        }
    }
}