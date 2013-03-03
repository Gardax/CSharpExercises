using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM
{
    public class GSM
    {
        string model;
        string manufacturer;
        double? price;
        string owner;
        Battery battery;
        Display Display;
        public static List<Call> callHistory= new List<Call>();
        public static GSM Iphone4S = new GSM("4S", "Apple", 1000, "Kiro Skalata", new Battery("Li/Ion", 200, 8), new Display(3.5, 16000000));
        public GSM(string model, string manufact, double? price=null, string owner=null, Battery battery=null, Display display=null)
        {
            this.model = model;
            this.manufacturer = manufact;
            this.price = price;
            this.owner = owner;
            this.battery = battery;
            this.Display = display;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Model: " + model);
            sb.Append("\nManufacturer: " + manufacturer);
            if (price != null)
            {
                sb.Append("\nPrice: " + price);
            }
            else
            {
                sb.Append("\nPrice: " + "NA");
            }
            if (owner != null)
            {
                sb.Append("\nOwner: " + owner);
            }
            else 
            {
                sb.Append("\nOwner: NA");
            }
            try
            {
                sb.Append("\nDispay size: " + Display.size);
            }
            catch
            {
                sb.Append("\nDispay size: NA");
            }
            try
            {
                sb.Append("\nDispay number of colors: " + Display.colors);
            }
            catch
            {
                sb.Append("\nDispay number of colors: NA");
            }
            try
            {
                sb.Append("\nBatery hours idle: " + battery.hoursIdle);
            }
            catch
            {
                sb.Append("\nBatery hours idle: NA");
            }
            try
            {
                sb.Append("\nBatery hours talk: " + battery.hoursTalk);
            }
            catch
            {
                sb.Append("\nBatery hours talk: NA");
            }
            try
            {
                sb.Append("\nBatery model: " + battery.model);
            }
            catch
            {
                sb.Append("\nBatery model: NA");
            }
            try
            {
                sb.Append("\nBatery type: " + battery.typeOfBattery);
            }
            catch
            {
                sb.Append("\nBatery type: NA");
            }
            return sb.ToString();
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
        public string Manufacturer
        {
            get
            {
                return manufacturer;
            }
            set 
            {
                manufacturer = value;
            }
        }
        public double? Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
        public string Owner
        {
            get
            {
                return owner;
            }
            set 
            {
                owner = value;
            }
        }
        public List<Call> GetCallHistory
        {
            get 
            {
                return callHistory;
            }
            set 
            {
                callHistory = value;
            }
        }
        public GSM IPhone4S
        {
            get { return Iphone4S; }
        }
        public  List<Call> CallHistory ()
        {
            return callHistory;
        }
        public void AddCall(string phone, int duration)
        {
            Call call = new Call(DateTime.Now, phone, duration);
            callHistory.Add(call);
        }
        public void DeleteCall(int callId)
        {
            callHistory.RemoveAt(callId);
        }
        public void ClearAllCallHistory()
        {
            callHistory.Clear();
        }
        public double TotalPriceOfCalls(double PricePerMinute)
        {
            double sum = 0;
            foreach (var item in callHistory)
            {
                sum += item.duration;
            }
            return sum * PricePerMinute;
        }
    }
    class MainProgram
    {
        static void Main()
        {
            GSMTest.Test();
            GSMCallHistoryTest.Calls();
        }
    }
}
