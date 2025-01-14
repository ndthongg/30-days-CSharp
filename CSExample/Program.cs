namespace CSExample
{
    internal class Program
    {
        // Branch with switch case and go to statements.
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Nhap a: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Nhap b: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Chon phep toan: ");
            Console.WriteLine("1. Cong");
            Console.WriteLine("2. Tru");
            Console.WriteLine("3. Nhan");
            Console.WriteLine("4. Chia");

            char kiTu;
            C1:
            kiTu = Console.ReadKey().KeyChar;
            Console.WriteLine();    

            switch (kiTu)
            {
                case '1':
                    Console.WriteLine($"Tong la: {a + b}");
                    break;
                case '2':
                    Console.WriteLine($"Hieu la: {a - b}");
                    break;
                case '3':
                    Console.WriteLine($"Tich la: {a * b}");
                    break;
                case '4':
                    Console.WriteLine($"Thuong la: {a / b}");
                    break;
                default:
                    Console.WriteLine("Ban nhap sai. Hay nhap lai");
                    goto C1;
                    break;
            }    

            Console.Title = "CSExample";

        }
    }
}
