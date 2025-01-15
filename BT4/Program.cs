using System;

namespace BT4
{
    internal class Program
    {
        /*
         
            Bài 8. Viết chương trình cho nhập vào số phải là số chính phương, 
                    xuất số vừa nhập ra màn hình.
         */
        static void Main(string[] args)
        {
            Console.Write("Nhap vao mot so nguyen: ");
            int n = int.Parse(Console.ReadLine());

            if (IsPerfectSquare(n))
            {
                Console.WriteLine("So vua nhap la so chinh phuong: " + n);
            }
            else
            {
                Console.WriteLine("So vua nhap khong phai la so chinh phuong.");
            }
        }

        static bool IsPerfectSquare(int n)
        {
            int sqrt = (int)Math.Sqrt(n);
            return sqrt * sqrt == n;
        }
    }
}
