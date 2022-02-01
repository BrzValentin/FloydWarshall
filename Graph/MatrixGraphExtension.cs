using Graph.Entity;

namespace Graph;

public static class MatrixGraphExtension
{
    public static void ReverseSignWithoutInfinity(this IMatrixGraph graph)
    {
        Utils.ReverseSignWithoutInfinity(graph.Matrix);
    }
}