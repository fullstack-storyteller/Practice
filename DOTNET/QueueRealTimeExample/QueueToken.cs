using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueRealTimeExample
{
    public class QueueToken
    {
        public static int LastToken = 0;
        public static Queue<int> TokenQueue = new Queue<int>();

    }
}
