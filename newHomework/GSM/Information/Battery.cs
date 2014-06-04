using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM
{
    public class Battery
    {
        public enum BatteryType
        {
            LiIon, NiMH, NiCd
        };
        internal string model;
        internal int? hoursIdle;
        internal int? hoursTalk;
        internal BatteryType? typeOfBattery;

        public Battery()
        {
            this.model = "Li/Ion";
            this.hoursIdle = 700;
            this.hoursTalk = 12;
        }
        public Battery(string model, int? hoursIdle=null, int? hoursTalk=null)
        {
            this.model = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
        }
        public string Model
        {
            get 
            {
                return model; 
            }
            set
            {
                model = value;
            }
        }
        public int? HoursIdle
        {
            get 
            {
                return hoursIdle;
            }
            set
            {
                hoursIdle = value;
            }
        }
        public int? HoursTalk
        {
            get
            {
                return hoursTalk;
            }
            set
            {
                hoursTalk = value;
            }
        }
    }
}
