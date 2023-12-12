using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20231211_MouaAngelina_Exercise4._2
{
    internal class HomeSales
    {
        static void Main(string[] args)
        {
            int Dsale = 0;
            int Esale = 0;
            int Fsale = 0;
            int totalsale = 0;
            string highestSeller = "none";
            while (true)
            {

                Console.WriteLine("Input Sales Person Initial: ");
                string salesPerson = Console.ReadLine();
                if (salesPerson == "Z")
                {
                    int[] salesMade = { Dsale, Esale, Fsale};
                    totalsale = Dsale + Esale + Fsale;
                    Console.WriteLine("Grand Total: " + totalsale);
                    Console.ReadLine();
                    if (Dsale > Esale && Dsale > Fsale)
                    {
                        highestSeller = "D";
                    }
                    else if (Esale > Dsale && Esale > Fsale)
                    {
                        highestSeller = "E";
                    }
                    else if (Fsale > Dsale && Fsale > Esale)
                    {
                        highestSeller = "F";
                    }
                    Console.WriteLine("Highest Sale: " + highestSeller);
                    Console.ReadLine();
                    break;
                }
                string[] validValues = new string[] { "D", "E", "F", "Z" };
                if (validValues.Contains(salesPerson))
                {


                }
                else
                {
                    Console.WriteLine("Intermediate Output: Error, Invalid Salesperson Selected, Please try again.");
                    Console.ReadLine();
                    continue;
                }
                Console.WriteLine("Input Sale Amount: ");
                int saleAmount = Convert.ToInt32(Console.ReadLine());



                if (salesPerson == "D")
                {
                    Dsale = saleAmount;
                    Console.WriteLine("D Sales: " + Dsale);
                    Console.ReadLine();
                    continue;
                }
                else if (salesPerson == "E")
                {
                    Esale = saleAmount;
                    Console.WriteLine("E Sales: " + Esale);
                    Console.ReadLine();
                    continue;
                }
                else if (salesPerson == "F")
                {
                    Fsale = saleAmount;
                    Console.WriteLine("F Sales: " + Fsale);
                    Console.ReadLine();
                    continue;
                }
                else if (salesPerson == "Z")
                {
                    totalsale = Dsale + Esale + Fsale;
                    Console.WriteLine("Grand Total: " + totalsale);
                    Console.ReadLine();
                    if (Dsale > Esale && Dsale > Fsale)
                    {
                        highestSeller = "D";
                    }
                    else if (Esale > Dsale && Esale > Fsale)
                    {
                        highestSeller = "E";
                    }
                    else if (Fsale > Dsale && Fsale > Esale)
                    {
                        highestSeller = "F";
                    }
                    Console.WriteLine("Highest Sale: " + highestSeller);
                }
                else
                {
                    Console.WriteLine("Intermediate Output: Error, Invalid Salesperson Selected, Please try again.");
                    Console.ReadLine();
                    continue;
                }
            }
        }
    }
}
