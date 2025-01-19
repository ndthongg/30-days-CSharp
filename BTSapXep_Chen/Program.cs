namespace BTSapXep_Chen
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

            Console.WriteLine("Original array: \t\t");
            foreach (var item in arr)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            // sắp xếp chèn (insertion sort)
            for (int i = 1; i < arr.Length; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }


            // In ra mảng sau khi sắp xếp
            Console.WriteLine("Array after Insertion Sort: \t");
            foreach (var item in arr)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

        }

        

        
            
        

        
    }
}