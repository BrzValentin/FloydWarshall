namespace Graph;

public class Utils
{
    public const string RelativePathToResFile = "..\\..\\..\\..\\Graph\\Res";
    
    public static List<int> ConvertToInts(string line)
    {
        return line.Split(' ').Select(int.Parse).ToList();
    }

    public static T[,] ConvertToArray<T>(IList<IList<T>> list)
    {
        int count = list.Count;
        T[,] matrix = new T[count, count];

        for (int i = 0; i < count; i++)
            for (int j = 0; j < count; j++)
                matrix[i, j] = list[i][j];

        return matrix;
    }
}