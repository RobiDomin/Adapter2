using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter2
{
    public interface IOldLogger
    {
        void Log(string message);
    }

    public class OldLogger : IOldLogger
    {
        public void Log(string message)
        {
            Console.WriteLine("OldLogger: " + message);
        }
    }
}
