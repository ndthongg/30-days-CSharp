namespace BT2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Bài 2. Viết chương trình nhập vào thông tin của một sinh viên gồm: + Mã số sinh viên (string)
            + Họ tên (string)
            + Điểm trung bình - ĐTB (float)
            Sau đó tính kết quả xếp loại của sinh viên, biết rằng:
            + ĐTB >= 8.0: loại giỏi
            + 8 > ĐTB >= 6.5: loại khá
            + 6.5 > ĐTB >= 5.0: loại trung bình
            + ĐTB < 5: loại yếu kém.
            Xuất đầy đủ thông tin của sinh viên.
             */
            string mssv, hoten, xeploai;
            float dtb;

            Console.Write("Nhap vao MSSV: ");
            mssv = Console.ReadLine();

            Console.Write("Nhap vao ho ten: ");
            hoten = Console.ReadLine();

            Console.Write("Nhap vao DiemTB: ");
            dtb = float.Parse(Console.ReadLine());

            if (dtb >= 8.5)
            {
                xeploai = "Gioi";
            }
            else if (dtb >= 6.5)
            {
                xeploai = "Kha";
            }
            else if (dtb >= 5.0)
            {
                xeploai = "Trung Binh";
            }
            else 
            {
                xeploai = "Yeu";
            }
            Console.WriteLine("\nMSSV: {0} \nHo ten: {1} \nDiemTB: {2} \nXep loai: {3}", mssv, hoten, dtb, xeploai);
            Console.Title = "Bai 2";
            Console.ReadLine();
        }
    }
}
