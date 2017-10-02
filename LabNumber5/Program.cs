using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ProgramContinue = true;

            while (ProgramContinue == true)
            {
                //Lab Numver 5- Serena Tindle

                int NumOfSides; //Declare Variables 
                string input;

                Console.WriteLine("Welcome to the Grand Circus Casino! Roll the dice? (n/y)"); //Ask for user input
                input = ValidateString();

                if (input == "no")
                {
                    ProgramContinue = false; //End program if user selects "no"
                }
                else
                {
                    Console.WriteLine("How many sides should each die have?"); //User inputs number of sides of the dice
                    NumOfSides = int.Parse(Console.ReadLine());
                    Console.WriteLine("Roll 1:");
                    Console.WriteLine(RndNum(1, NumOfSides)); //output
                    Console.WriteLine(RndNum(1, NumOfSides));
                    
                }

            }
        }

        public static int RndNum(int min, int max)
        {

            Random rnd = new Random(Guid.NewGuid().GetHashCode()); //creates random numbers (added randome seed code

            int result = rnd.Next(min, max + 1); //range is min and max, always add extra "1"
            return result;

        }

        public static string ValidateString()
        {

            bool Validate = true;
            string UserInput = "";
            while (Validate == true)
            {
                UserInput = (Console.ReadLine());
                if (UserInput != "yes" && UserInput != "no")
                {
                    Console.WriteLine("Please enter yes or no!");
                }
                else
                    Validate = false;
            }
            return UserInput;
        }


    }
}
