using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM
{
    public class Call
    {
        internal DateTime date;
        internal string phoneNumber;
        internal int duration;
        public Call(DateTime date, string phone, int duration)
        {
            this.date = date;
            this.phoneNumber = phone;
            this.duration=duration;
        }
    }
}
