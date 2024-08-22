using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int idade = 34;

            if (idade > 18)
            {
               Console.WriteLine("Verdade");
            }
            else{
               Console.WriteLine("Mentira"); 
            }

            
            


            Console.ReadLine();
              
        }
    }
}
