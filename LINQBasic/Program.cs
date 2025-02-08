namespace LINQBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string header = "";
            //for (int i = 0; i < 80; i++)
            //{
            //    header += "=";
            //}

            //Console.WriteLine(header);
            //string header = new string('=', 80);
            //Console.WriteLine(header);

            var data = GetIntNumber();
            Print(data);


            // VIET LINQ DUOI DANG QUERY SYNTAX

            /*Bien n se dai dien cho tung phan tu trong data
            va chung ta co the thuc hien cac phep toan tren n ( bao gom ca so sanh)
            */
            var so = from n in data
                     where IsGreaterThanOne(n) && n % 2 == 1
                     select n;


            // VIET LINQ DUOI DANG METHOD SYNTAX

            //LINGQ duoi dang lambda
            //var so = data.Where(n => IsGreaterThanOne(n) && n % 2 == 1);

            Console.ReadLine();
            
            Console.WriteLine(so.Count());
        }

        static bool IsGreaterThanOne(int n)
        {
            Console.WriteLine($"{n} > 1 = {n > 1}");
            return (n > 1);
        }
        static IEnumerable<int> GetIntNumber()
        {
            var so = new int[] {0, 1, 2, 3 };
            return so;
        }

        static void Print(IEnumerable<int> list)
        {
            Console.WriteLine();
            foreach (var i in list)
            {
                Console.WriteLine(i);
            }
            
        }
    }
}
