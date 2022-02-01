namespace Graph.Entity;

public interface IMatrixNetwork : IMatrixGraph
{
    int SourceIndex { get; set; }
    
    int SinkIndex { get; set; }
}