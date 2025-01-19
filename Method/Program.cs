namespace Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // 1.
           int a = 5, b = 10;
            Console.WriteLine($"Before swapping: a = {a}, b = {b}");
            SwapNumbers(ref a, ref b);
            Console.WriteLine($"After swapping: a = {a}, b = {b}");
            Console.WriteLine();

            // 2.
            Console.WriteLine("\nDay so Fibonacci 8 so dau tien:");
            PrintFibonacci(8);

            Console.WriteLine();
            // 3.
            int quotient, remainder;
            DivideNumbers(17, 5, out quotient, out remainder);
            Console.WriteLine($"\nPhep chia 17/5: Thuong = {quotient}, Du = {remainder}");
            Console.WriteLine();

            // 4.
            int result1 = Sum(1, 2, 3);
            int result2 = Sum(1, 2, 3, 4, 5);
            Console.WriteLine($"\nTong cua 1,2,3 = {result1}");
            Console.WriteLine($"Tong cua 1,2,3,4,5 = {result2}");
        }

        // 1. Hàm tráo đổi 2 số sử dụng ref
        static void SwapNumbers(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        // 2. Hàm in dãy số Fibonacci
        static void PrintFibonacci(int n)
        {
            int a = 0, b = 1;
            Console.Write($"{a} {b} ");
            for (int i = 2; i < n; i++)
            {
                int c = a + b;
                Console.Write($"{c} ");
                a = b;
                b = c;
            }
            Console.WriteLine();
        }

        // 3. Ví dụ sử dụng từ khóa out
        static void DivideNumbers(int dividend, int divisor, out int quotient, out int remainder)
        {
            quotient = dividend / divisor;
            remainder = dividend % divisor;
        }

        // 4. Ví dụ sử dụng từ khóa params
        static int Sum(params int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }

    }
}
