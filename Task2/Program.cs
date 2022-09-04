internal partial class Program
{
    private static void Main(string[] args)
    {
        int M = InpNum("M: ");
        int N = InpNum("N: ");
        int temp = M;

        if (M > N)
        {
            M = N;
            N = temp;
        }
        PrintSum(M, N, temp = 0);

        void PrintSum(int M, int N, int sum)
        {
            sum = sum + N;
            if (N <= M)
            {
                Console.Write($"{sum}");
                return;
            }
            PrintSum(M, N - 1, sum);
        }

        int InpNum(string input)
        {
            Console.Write(input);
            int output = Convert.ToInt32(Console.ReadLine());
            return output;
        }
    }
}