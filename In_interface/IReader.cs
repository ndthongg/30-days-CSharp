using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace In_interface
{
    internal interface IReader
    {
        string Name { get;}
        int ReadInt();
        string ReadString();

        static void WriteName(IReader reader)
        {
            Console.WriteLine(reader.Name);
        }

    }
}
