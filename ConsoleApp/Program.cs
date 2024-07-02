var rand = new Random();

do
{
    var n = rand.Next(1, 42); 
    Console.WriteLine($"Randomly generated n: {n}");
    Console.WriteLine($"Fibonacci number at position {n}: {Fibonacci(n)}");
} while (true);

static int Fibonacci(int n)
{
    if (n <= 1)
    {
        return n; 
    }

    return Fibonacci(n - 1) + Fibonacci(n - 2);
}
