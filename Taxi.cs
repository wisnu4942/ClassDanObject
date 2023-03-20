using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanClassDanObject2
{
    public class Taxi
    {
        public string DriverName { get;set; }
        public bool OnDuty { get;set; }
        public int NumPassanger { get;set; }

        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name: {0}", DriverName);
            if (OnDuty == true)
            {
                Console.WriteLine("On Duty: Yes");
            } else if (OnDuty == false)
            {
                Console.WriteLine("On Duty: No");
            }
            Console.WriteLine("Number of Passanger: {0}", NumPassanger);
        }
        public void PicUpPassanger()
        {
            Console.WriteLine("\n{0} sedang menjemput penumpang", DriverName);
        }
        public void DropOffPassanger()
        {
            Console.WriteLine("{0} selesai mengantar penumpang", DriverName);
        }
    }
}
