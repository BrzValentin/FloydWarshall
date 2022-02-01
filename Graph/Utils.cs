namespace Graph;

public class Utils
{
    public const string RelativePathToResFile = "..\\..\\..\\..\\Graph\\Res";

    public static List<double> ConvertToDouble(string line)
    {
        return line.Split(' ').Select(double.Parse).ToList();
    }

    public static void ReverseSignWithoutInfinity(double[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (double.IsInfinity(matrix[i, j])) continue;
                matrix[i, j] *= -1;
            }
        }
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

    public static T[,] Copy<T>(T[,] array)
    {
        int n = array.GetLength(0);
        var copy = new T[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                copy[i, j] = array[i, j];
            }
        }

        return copy;
    }

    public static T[] Copy<T>(T[] array)
    {
        int n = array.Length;
        var copy = new T[n];
        for (int j = 0; j < n; j++)
        {
            copy[j] = array[j];
        }
        
        return copy;
    }
}