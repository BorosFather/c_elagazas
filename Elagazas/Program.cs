using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elagazas{

    internal class Program{

        static void Main(string[] args){

            Console.Write("adjon meg egy szamot: ");
            int num = int.Parse(Console.ReadLine());

            //a 0 at negativnak irja
            //if (num > 0)
            if (num > 0 && num <= 15)
            {

                Console.WriteLine("a szam pozitiv!");
            }
            //else if el megvizsgalom a 0 at 
            else if (num == 0)
            {
                Console.WriteLine("Ez a szam nulla!");
            }
            else if (num < 0)
            {
                Console.WriteLine("a szam negativ!");
            }
            else {
                Console.WriteLine("A szam 15 nel nagzobb!");
            }

            //Felteteles operator

            Console.WriteLine((num >= 12) ? "A szam nagyobb vagz egyello, mit 12": "A szam kissebb 12 nel!");
            Console.WriteLine((num % 2 == 0 ) ? "A szam paros" : "A szam a paratlan");

            //Console.Write("adjon meg egy szmot");
            //int num2 = int.Parse(Console.ReadLine());

            if (num % 2 == 0 && num % 2 == 3)

                Console.WriteLine("A szam ohszhato 2 ve es 3 mal");

            else
                if (num % 2 == 0)

                Console.WriteLine("A szam nem oszhato 3al");

            else if (num % 3 == 0)
                Console.WriteLine("A szam nem oszhato 2 vel");

            else
                Console.WriteLine("A szam nem oszhato se 2 vel se 3 mal");


            //kerjunk be egy valos szamot, majd vizsgaljuk meg hogy a bekert szam oszthato e PIvel 
            //ha igen ugy irjuk ki hogy kiraly egyepkent elbaltaztad


            Console.Write("Kerem irjon be egy volos szamot: ");
            double num2 = double.Parse(Console.ReadLine());

            if (num2 % Math.PI == 0)
            {
                Console.WriteLine("kiraly vagy!");
            } else {

                Console.WriteLine("Ezt elbaltaztad!! xD");
            }

            Console.ReadKey();
        }
    }
}
