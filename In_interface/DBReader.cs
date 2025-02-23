using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace In_interface
{
    internal class DBReader : IReader
    {
        public string Name => "DBReader";
        

        public int ReadInt()
        {
            return 1;
        }

        public string ReadString()
        {
            return "DBReader";
        }
    }
}
