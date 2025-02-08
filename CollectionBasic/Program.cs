
namespace CollectionBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string>();

            ReadString(list);
            PrintList(list);
            SortedList(list);

        }

        private static void SortedList(List<string> list)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[i].CompareTo(list[j]) > 0)
                    {
                        var s = list[i];
                        list[i] = list[j];
                        list[j] = s;
                    }
                }
            }
        }

        private static void ReadString(List<string> list)
        {
            string? s;
            do
            {
                
                s = Console.ReadLine();
                if (!string.IsNullOrEmpty(s))
                {
                    list.Add(s);
                }
            } while (!string.IsNullOrEmpty(s));

        }

        private static void PrintList(List<string> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
        }
    }
}
