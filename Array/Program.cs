namespace Array
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            // MẢNG 1 CHIỀU
            //string[] dssv = new string[5];

            //dssv[0] = "Nguyen Van A";
            //dssv[1] = "Nguyen Van B";
            //dssv[2] = "Nguyen Van C";
            //dssv[3] = "Nguyen Van D";
            //dssv[4] = "Nguyen Van E";


            //for (int i = 0; i <= 2; i++)
            //{
            //    Console.WriteLine(dssv[i]);
            //}

            //int[] numbers = { 11, 12, 13, 14, 15, 16, 17, 18, 9, 10 };
            //int soPhanTu = number.Length;

            // Duyệt phần tử bằng for
            /*
            for (int chiso = soPhanTu - 1; chiso >= 0; chiso--)
            {
                Console.WriteLine(number[chiso]);
            }
            */

            // Duyệt phần tử bằng foreach
            /*
            foreach (int item in number)
            {
                Console.WriteLine(item);
            }
            */

            // Duyệt phần tử bằng Linq
            //Console.WriteLine($"So phan tu co trong mang: {number.Length}");
            //Console.WriteLine($"So phan tu co trong mang: {number.Count()}");

            //Console.WriteLine($"So chieu cua mang: {number.Rank}");

            //Console.WriteLine($"Min: {number.Min()}");
            //Console.WriteLine($"Max: {number.Max()}");
            //Console.WriteLine($"Sum: {number.Sum()}");
          


            // MẢNG 2 CHIỀU
            /*
                0 1 2
            0   4 3 4
            1   5 6 6.5


             */
            double[,] diem = new double[2, 3] { { 4, 3, 4 }, { 5, 6, 6.5 } };
            //Console.WriteLine(diem[1, 2]);

            int hang = 2;
            int cot = 3;

            for (int i = 0; i < hang; i++)
            {
                for (int j = 0; j < cot; j++)
                {
                    Console.Write(diem[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
