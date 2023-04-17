using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Operations
    {
        //    console.writeline("1. suma");
        //    console.writeline("2. resta");
        //    console.writeline("3. multiplicacion");
        //    console.writeline("4. division");
        //    console.writeline("5. cuadrado");
        //    console.writeline("6. raiz cuadrada");

        public int opcuser { get; set; }
        public double number1 {  get; set; }
        public double number2 { get; set; }

        double solution;

        public Operations(int opcuser,double number1, double number2) {

            this.opcuser = opcuser;
            this.number1 = number1;
            this.number2 = number2;

            switch (opcuser){
                case 1:
                     solution= number1 + number2;                  
                     break;
                
                case 2:
                     solution = number1 - number2;
                     break;

                case 3:
                     solution = number1 * number2;
                     break;

                case 4:
                    solution = number1 / number2;
                    break;

                case 5:
                    solution = number1 * number1;
                    break;

                case 6:
                    solution = Math.Sqrt(number1);
                    break;


            }

            PrintResults print = new PrintResults(solution);



        }

        

    }
}
