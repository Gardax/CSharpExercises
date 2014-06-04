using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM
{
    public class Display
    {
        internal double? size;
        internal int? colors;
        public Display(double? inches=null, int? numberOfColors=null)
        {
            this.size = inches;
            this.colors=numberOfColors;
        }
        public double? Size
        {
            get 
            {
                return size;
            }
            set
            {
                size = value;
            }
        }
        public int? NumberOfColors
        {
            get
            {
                return colors;
            }
            set 
            {
                colors = value;
            }
        }
    }
}
