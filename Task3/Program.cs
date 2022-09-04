int m = InputNumbers("m: ");
int n = InputNumbers("n: ");
int A = AkkF(m, n);
Console.Write($"A(m, n) = {A}");

int AkkF(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return AkkF(m - 1, 1);
  else return AkkF(m - 1, AkkF(m, n - 1));
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}