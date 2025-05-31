using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter2
{
    public class NewLogger
    {
        public void WriteLog(string text)
        {
            Console.WriteLine("NewLogger: " + text);
        }
    }
}
