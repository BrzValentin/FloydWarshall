namespace Graph.Entity;

public interface IMatrixNetwork : IMatrixGraph
{
    (int, int) SourceIndex { get; set; }
    
    (int, int) SinkIndex { get; set; }
}