using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace In_interface
{
    internal class ConsoleReader : IReader
    {
        public string Name => "ConsoleReader";

        public int ReadInt()
        {
            return int.Parse(Console.ReadLine());
        }

        public string? ReadString()
        {
            return Console.ReadLine();
        }
    }
}
