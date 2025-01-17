namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HoTen("Van A", "Nguyen");
        }

        public static void HoTen(string ten, string ho)
        {
            string fullname;
            fullname = ho + " " + ten;

            Console.WriteLine($"Xin chao { fullname} ");

        }

    }
}
