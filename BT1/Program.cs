namespace BT1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bai 1: Viet chuong trinh nhap vao 2 so nguyen a va b. Xuat tong, hieu, tich, thuong cua 2 so do

            int a, b;
            Console.Write("Nhap vao so nguyen a: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Nhap vao so nguyen b: ");
            b = int.Parse(Console.ReadLine());

            //// Tong cua 2 so a va b
            //Console.WriteLine("Tong cua hai so la: {0} ", a + b);

            //// Hieu cua 2 so a va b
            //Console.WriteLine("Hieu cua hai so la: {0} ", a - b);

            //// Tich cua 2 so a va b
            //Console.WriteLine("Tich cua hai so la: {0} ", a * b);

            // Thuong cua 2 so a va b (khong lay du)
            Console.WriteLine("Tich cua hai so la: {0}  \nThuong cua hai so la: {1}", a * b, a % b);

            Console.Title = "Bai 1";
            Console.ReadLine();
        }
    }
}
