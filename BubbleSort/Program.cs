namespace BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            var arr = new int[10];

            for (int k = 0; k < arr.Length; k++)
            {
                arr[k] = rand.Next() % 1000;
            }

            Console.Write("Original array: \t\t");
            foreach (var item in arr)
            {
                Console.Write($"{item}\t");
            }

            Console.WriteLine();

            // sắp xếp bằng phương pháp Bubble Sort
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        var temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            // In ra mảng sau khi sắp xếp
            Console.Write("Array after Bubble Sort: \t");
            foreach (var item in arr)
            {
                Console.Write($"{item}\t");
            }
        }
    }
}
