namespace BT6
{
    internal class Program
    {

        /*BT mảng: in ra mảng và tim vị trí của phần từ trong mảng*/
        static void Main(string[] args)
        {
            var rand = new Random();
            var arr = new int[10];
            int i;

            for ( i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next() % 1000;
            }

            foreach (var item in arr)
            {
                Console.Write($"{item}\t");
            }

            Console.WriteLine();
            Console.Write("Nhap so can tim: ");

            var s = Console.ReadLine();
            int soCanTim = int.Parse(s);

            i = 0;
            while (i < arr.Length && arr[i] != soCanTim)
            {
                i++;
            }

            if (i < arr.Length)
            {
                Console.WriteLine($"Tim thay {soCanTim} tai vi tri {i}");
            }
            else
            {
                Console.WriteLine($"Khong tim thay {soCanTim}");
            }

        }
    }
}
