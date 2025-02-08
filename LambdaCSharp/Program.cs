



namespace LambdaCSharp
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    // => is the lambda operator
        //    // (int a, int b) is the parameter list
        //    // a + b is the expression
        //    //Func<int ,int, string> sum = (int a, int b) => a + b.ToString();

        //    //// var printUpper = (string s) => Console.WriteLine(s.ToUpper());
        //    //Action<string> printUpper = (s) => Console.WriteLine(s.ToUpper());

        //    //Console.WriteLine(sum(1, 2));

        //    //printUpper("Hello, World!");

        //    int A = 100;
        //    int B = 200;

        //    Call((a, b) => a + b, A, B);
        //    Call((a, b) => a - b, A, B);
        //}

        //private static void Call(Func<int, int, int> value, int a, int b)
        //{
        //    Console.WriteLine(value(a, b));
        //}

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

           Print(x => x > 5, arr);
        }

        private static void Print(Func<int ,bool> value, int[] arr )
        {
            foreach (var item in arr)
            {
                if (value(item))
                {
                    Console.WriteLine($"{item}  ");
                }
            }
        }
    }
}
