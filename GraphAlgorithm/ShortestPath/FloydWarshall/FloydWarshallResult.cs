namespace GraphAlgorithm.ShortestPath.FloydWarshall;

public class FloydWarshallResult
{
    public double[,] Distances { get; set; }
    
    public int[,] Parents { get; set; }
    
    public FloydWarshallResult(double[,] distances, int[,] parents)
    {
        Distances = distances;
        Parents = parents;
    }
}