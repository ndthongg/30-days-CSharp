namespace CS01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Tim GTLN cua 2 so a va b

            //float a, b, max;

            //a = float.Parse(Console.ReadLine());
            //b = float.Parse(Console.ReadLine());


            //if (a > b)
            //{
            //    max = a;
            //}
            //else
            //{
            //    max = b;
            //}
            /* => co the toi uu bang TOAN TU 3 NGOI*/

            //    max = (a > b) ? a : b;
            //Console.WriteLine("So lon nhat la {0}", max);

            // Tim GTLN cua 3 so a, b, c
            float a, b, c, max;
            a = float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());
            c = float.Parse(Console.ReadLine());

            //if (a > b)
            //{
            //    if ( a > c)
            //    {
            //        max = a;
            //    }    
            //    else
            //    {
            //        max = c;
            //    }    
            //}    
            //else
            //{
            //    if( b > c)
            //    {
            //        max = b;
            //    }    
            //    else
            //    {
            //        max = c;
            //    }    
            //}

            /* => co the toi uu bang TOAN TU 3 NGOI*/
            max = (a > b) ? (a > c) ? a : c : (b > c) ? b : c;
            Console.WriteLine("So lon nhat la {0}", max);
        }
    }
}
