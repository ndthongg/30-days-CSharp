namespace BT3
{
    internal class Program
    {

        /*
            Bài 7. Viết chương trình nhập vào 1 số nguyên n.
            Phân tích n ra thừa số nguyên tố.
            Cho biết n có bao nhiêu chữ số.
         */
        static void Main(string[] args)
        {
            Console.Write("Nhap vao mot so nguyen n: ");
            int n = int.Parse(Console.ReadLine());

            // Phan tich n ra thua so nguyen to
            List<int> primeFactors = GetPrimeFactors(n);
            Console.WriteLine("Cac thua so nguyen to cua n la: " + string.Join(", ", primeFactors));

            // Cho biet n co bao nhieu chu so
            int digitCount = n.ToString().Length;
            Console.WriteLine("So n co " + digitCount + " chu so.");
        }

        static List<int> GetPrimeFactors(int n)
        {
            List<int> factors = new List<int>();
            for (int i = 2; i <= n / i; i++)
            {
                while (n % i == 0)
                {
                    factors.Add(i);
                    n /= i;
                }
            }
            if (n > 1)
            {
                factors.Add(n);
            }
            return factors;
        }
    }
}
