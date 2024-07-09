using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAppTieto;

namespace TestAppTieto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello TietoEvry");
            calculation calculation = new calculation();
            Console.WriteLine("Addition ->"+ calculation.add(20,10));
            Console.WriteLine("Substraction ->"+ calculation.subtract(20,10));
            Console.WriteLine("Add->"+calculation.add(10,90));
            Console.WriteLine("Subs->" + calculation.subtract(100, 50));
            Console.Read();
        }
    }
}
