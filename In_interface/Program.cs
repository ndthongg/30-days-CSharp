namespace In_interface
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var reader = new DBReader();
            Read(reader);
        }

        static void Read(IReader reader)
        {
            IReader.WriteName(reader);

            Console.WriteLine(reader.Name);


            Console.Write("Nhap int: ");
            int i = reader.ReadInt();

            Console.Write("Nhap string: ");
            string s = reader.ReadString();


            Console.WriteLine($"i = {i}, s = {s}");
        }
    }
}
