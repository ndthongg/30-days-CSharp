namespace TryCatchException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ví dụ vễ exception
            try
            {
                Console.Write("Nhap so a: ");
                int a = int.Parse(Console.ReadLine());

                int x = 10 / a;
                Console.WriteLine($"  10/{a} = {x}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            // catch block có thể xử lý nhiều exception
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            // finally block sẽ luôn được thực thi dù có exception hay không
            // thường được sử dụng để giải phóng tài nguyên và đóng connection trong CSDL (dù là có lỗi)
            finally
            {
                Console.WriteLine("Ket thuc chuong trinh");
            }

        }
    }
}
