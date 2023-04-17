using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class PrintResults
    {
        public double solution { get; set; }

        public PrintResults(double solution)
        {
            this.solution = solution;
            Console.WriteLine("---------------------");
            Console.WriteLine($"={solution}");
        }


       
        }

    }

