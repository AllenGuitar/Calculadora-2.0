namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("Por favor ingrese la operacion que desea realizar");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicacion");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Cuadrado");
            Console.WriteLine("6. Raiz cuadrada");
            Console.WriteLine("-------------------------------------------------");

            Console.ForegroundColor = ConsoleColor.Gray;

            string opcuserstr = Console.ReadLine();
            int opcuser;

            int.TryParse(opcuserstr, out opcuser);

            while (opcuserstr == "" || int.TryParse(opcuserstr, out opcuser) == false || opcuser <= 0 || opcuser > 6)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("El valor ingresado es erroneo, Por favor digite un valor");
                Console.ForegroundColor = ConsoleColor.Gray;
                opcuserstr = Console.ReadLine();
            }

            
            int.TryParse(opcuserstr, out opcuser);
            

            string convnum1;
            string convnum2;

            double num1;
            double num2;

            Console.WriteLine("Por favor ingrese el primer numero");
            convnum1 = Console.ReadLine();

            while (convnum1 == "" || double.TryParse(convnum1, out num1) == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("El valor ingresado es incorrecto, por favor digite un valor");
                Console.ForegroundColor = ConsoleColor.Gray;
                convnum1 = Console.ReadLine();
            }
            
            double.TryParse(convnum1, out num1);

            if (opcuser == 5 || opcuser == 6)
            {
                num2 = 0;
            }
            else
            {
                Console.WriteLine("Por favor ingrese el segundo numero");
                convnum2 = Console.ReadLine();

                while (convnum2 == "" || double.TryParse(convnum2, out num2) == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("El valor ingresado es incorrecto, por favor digite un valor");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    convnum2 = Console.ReadLine();
                }
                
                double.TryParse(convnum2, out num2);


            }


            Console.ForegroundColor = ConsoleColor.Green;

            Operations operation = new Operations(opcuser, num1, num2);




        }

    }
}
