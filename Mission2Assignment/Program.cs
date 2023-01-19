using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2Assignment
{
    //declaring the class
    class Program
    {
        static void Main(string[] args)
        {
            //asking the user to input the # of dice rolls
            Console.Write("Welcome to the dice throwing simulator!\n");
            Console.Write("How many dice rolls would you like to simulate? ");
            string val = Console.ReadLine();
            int rolls = Convert.ToInt32(val);

            //creating the list of 11 different roll options
            float[] listRolls = new float[11];

            //Creating the random roll
            Random dice = new Random();

            //Looping through the # of rolls and adding the results to the roll option list
            for (int i = 0; i < rolls; i++)
            {
                int rollTotal = (dice.Next(11) + 1);
                listRolls[rollTotal - 1]++;
            }

            Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each '*' represents 1 % of the total number of rolls.");
            Console.WriteLine("Total number of rolls = " + rolls + ".\n");

            //Calculating the # of rolls and creating the 1 % of rolls per number chosen
            for (int x = 0; x < listRolls.Length; x++)
            {
                float fRollCount = ((listRolls[x]/rolls)*100);
                int iRollCount = (int)Math.Round(fRollCount);
                string output = new String('*', iRollCount);
                Console.WriteLine((x + 2) + ": "+ output);

            }
            Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
        }
    }
}
