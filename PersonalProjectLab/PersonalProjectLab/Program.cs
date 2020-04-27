using System;

namespace PersonalProjectLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Cantilever Deflection Calculator");
            Console.WriteLine();

            bool shouldContinue = true;

            while (shouldContinue)
            {
                //Variables
                decimal modulusE;
                int height;
                int width;
                int length;
                int loadLength;
                int force;
                decimal inertia;
                decimal deflection = 0;
                int materialChoice;
                string input = "";

                Console.WriteLine("All units are in inches");

                Console.WriteLine("Enter length of beam");
                input = Console.ReadLine();
                length = int.Parse(input);

                Console.WriteLine("Enter length of beam where force is applied");
                input = Console.ReadLine();
                loadLength = int.Parse(input);

                Console.WriteLine("Enter height of beam");
                input = Console.ReadLine();
                height = int.Parse(input);

                Console.WriteLine("Enter width of beam");
                input = Console.ReadLine();
                width = int.Parse(input);

                Console.WriteLine("Beam Materials");
                Console.WriteLine("Enter 1 for Wood");
                Console.WriteLine("Enter 2 for Steel");
                input = Console.ReadLine();
                materialChoice = int.Parse(input);
                    

                if (materialChoice == 1)
                {
                    modulusE = (decimal)(1.8 * Math.Pow(10, 6));
                }
                else
                {
                    modulusE = (decimal)(26 * Math.Pow(10, 6));
                }

                Console.WriteLine("Force loaded on the end of the beam in pounds");
                input = Console.ReadLine();
                force = int.Parse(input);

                CalculatorEngine engine = new CalculatorEngine();

                inertia = engine.CalculateInertia(width, height);
                deflection = engine.CalculateDeflection(force, length, loadLength, modulusE, inertia);

                Console.WriteLine("The Deflection at " + loadLength + " in. will be " + deflection + " in.");

                Console.WriteLine("Press 1 to run another calculation");
                Console.WriteLine("Press 2 to exit calulator");

                input = Console.ReadLine();
               

                if(input == "2")
                {
                    shouldContinue = false;
                }
                else
                {

                }
            }




		}
	}
}