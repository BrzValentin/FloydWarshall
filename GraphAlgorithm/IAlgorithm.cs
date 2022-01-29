using Graph.Entity;

namespace GraphAlgorithm;

public interface IAlgorithm
{
    Algorithm Algorithm { get; }

    void Run(IMatrixGraph graph);
}