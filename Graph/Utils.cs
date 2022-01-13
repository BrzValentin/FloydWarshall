namespace Graph;

class Utils
{
    public static List<int> ConvertToInts(string line)
    {
        return line.Split(' ').Select(int.Parse).ToList();
    }

    public static T[,] ConvertToArray<T>(List<List<T>> list)
    {
        int count = list.Count;
        T[,] matrix = new T[count, count];

        for (int i = 0; i < count; i++)
            for (int j = 0; j < count; j++)
                matrix[i, j] = list[i][j];

        return matrix;
    }
}