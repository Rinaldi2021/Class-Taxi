/* NAMA  : RINALDI FITRAHUDA RADITYA
 * NIM   : 20.11.3378
 * KELAS : 20 IF 02
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pemrograman02
{
    class Program
    {
        static void Main(string[] args)
        {
            Taxi taxi = new Taxi();

            taxi.DriverName = "Jono";
            taxi.OnDuty = false;
            taxi.NumPassenger = 10;

            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DropOffPassenger();

            Console.ReadKey();
        }
    }

    class Taxi
    {
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public int NumPassenger { get; set; }

        public void TaxiInfo()
        {

            Console.WriteLine("Driver Name         : {0}", DriverName);

            if (OnDuty == true)
            {
                Console.WriteLine("On Duty             : Yes", OnDuty);
            } else
            {
                Console.WriteLine("On Duty             : No", OnDuty);
            }

            Console.WriteLine("Number Of Passenger : {0}\n", NumPassenger);

        }

        public void PickUpPassenger()
        {
            Console.WriteLine("{0} sedang menjemput penumpang", DriverName);

        }

        public void DropOffPassenger()
        {
            Console.WriteLine("{0} selesai menjemput penumpang", DriverName);
        }

    }
}
