namespace BTSapXep_Chon
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

            // sắp xếp chọn (selection sort)
            /*
            Nhược điểm của Selection Sort:
            1.	Hiệu suất kém: Độ phức tạp thời gian của Selection Sort là O(n^2), khiến nó không hiệu quả cho các mảng lớn.
            2.	Không ổn định: Selection Sort không phải là một thuật toán ổn định, nghĩa là các phần tử có giá trị bằng nhau có thể thay đổi thứ tự tương đối của chúng sau khi sắp xếp.
            3.	Không tối ưu: Thuật toán này không tận dụng được các đặc điểm của mảng đã sắp xếp một phần, do đó nó luôn thực hiện cùng số lượng phép so sánh và hoán đổi bất kể mảng đầu vào như thế nào.
            Cải thiện:
            Để cải thiện hiệu suất, bạn có thể sử dụng các thuật toán sắp xếp khác như:
            Quick Sort, 
            Merge Sort, hoặc 
            Heap Sort, có độ phức tạp thời gian trung bình là O(n log n).
             */
            //Duyệt qua từng phần tử của mảng từ đầu đến cuối
            for (int i = 0; i < arr.Length - 1; i++)
            {
                //Duyệt ngược từ cuối mảng về vị trí hiện tại của vòng lặp ngoài.
                for (int j = arr.Length - 1; j > i; j--)
                {
                    //Kiểm tra nếu phần tử tại vị trí i lớn hơn phần tử tại vị trí j
                    if (arr[i] > arr[j])
                    {
                        var temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            Console.Write("Array after Selection Sort: \t");
            foreach (var item in arr)
            {
                Console.Write($"{item}\t");
            }
        }
    }
}
