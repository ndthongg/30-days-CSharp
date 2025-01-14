namespace LoopStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // For loop statement
            /*
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"3 x {i} = {3 * i}");
            }
            */


            // While loop statement
            /*
            int i = 1;
            while(i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }    
            */


            // Do-While loop statement
            /**/
            int i = 1;
            do
            {
                Console.WriteLine($" 3 x {i} = {3 * i}");
                i++;
            } while (i <= 10);

        }
    }
}
