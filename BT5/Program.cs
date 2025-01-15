namespace BT5
{
    internal class Program
    {

        /*
            Bài 9. Nhập vào 1 ngày tháng năm. Cho biết ngày trước đó và ngày hôm sau là ngày mấy.
         */
        static void Main(string[] args)
        {
            Console.Write("Nhap vao ngay (dd): ");
            int day = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao thang (MM): ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao nam (yyyy): ");
            int year = int.Parse(Console.ReadLine());

            DateTime inputDate = new DateTime(year, month, day);
            DateTime previousDay = inputDate.AddDays(-1);
            DateTime nextDay = inputDate.AddDays(1);

            Console.WriteLine("Ngay truoc do la: " + previousDay.ToString("dd/MM/yyyy"));
            Console.WriteLine("Ngay hom sau la: " + nextDay.ToString("dd/MM/yyyy"));
        }
    }
}
