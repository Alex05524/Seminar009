internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("M: ");
        int M = Convert.ToInt16(Console.ReadLine());
        Console.Write("N: ");
        int N = Convert.ToInt16(Console.ReadLine());
        if (N > M)
            for (int i = M; i <= N; i++)
            {
                Console.Write($"{i}, ");
            }
        else
            for (int i = N; i <= M; i++);
    }
}