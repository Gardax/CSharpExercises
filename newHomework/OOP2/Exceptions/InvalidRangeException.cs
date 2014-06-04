using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class InvalidRangeException<T>:Exception
    {
        public T from { get; set; }
        public T to { get; set; }
        public InvalidRangeException(string message, T from, T to)
            : base(message)
        {
            this.from = from;
            this.to = to;
        }
    }
}
