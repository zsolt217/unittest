using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elso_fzsolt
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Calculator calculator = new Calculator();

                Console.WriteLine("Adja meg az összeadandó számokat! Formátum:elsősz,második.");
                string parameters = Console.ReadLine();
                int result = calculator.Add(parameters);

                Console.WriteLine(result);
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }
    }
}
