using System;

namespace Calculator
{
	/// <summary>
	/// The class for this program
	/// </summary>
	internal class Program
	{
		/// <summary>
		/// The name of this program
		/// </summary>
		public const string ProgramName = "The Calculator 2000";
		
		/// <summary>
		/// The start point of this program
		/// </summary>
		/// <param name="args">Anything</param>
		static void Main(string[] args)
		{
			// Variable for user choise
			int choise;

			// Welcome the user to this program
			Console.WriteLine($"Welcome to {ProgramName}!");

			// Make a pause in this program
			Console.ReadKey();

			do
			{
				// Show the menu of this program and wait for user make their chosie
				int.TryParse(Menu(), out choise);

				// Make a pause in this program
				Console.ReadKey();

			} while (choise != 99);
		}
		
		/// <summary>
		/// Show the menu of this program and wait for the users had make their choise
		/// </summary>
		/// <returns>The user choise</returns>
		static string Menu()
		{
			// Create a empty console window, then show the name of this program
			Console.Clear();
            Console.WriteLine(ProgramName);

            // Make a empty row
            Console.WriteLine();

			// Show a header of the menu
			ShowAHeader("Menu");

            // Make a empty row
            Console.WriteLine();

            // Show the menu itself
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
			Console.WriteLine("3. Division");
            Console.WriteLine("4. Multiplication");

            Console.WriteLine("99. Quit the program");

            // Make a empty row
            Console.WriteLine();

			Console.Write("Make your choise: ");
			return Console.ReadLine();
        }
		
		/// <summary>
		/// Show a header in console window
		/// </summary>
		/// <param name="title">The text in the header</param>
		static void ShowAHeader( string title ) => Console.WriteLine($"********** {title} **********");
		/// <summary>
		/// Collecting of some integer values
		/// </summary>
		/// <returns>A array of integer values</returns>
		static int[] GetSomeInterger()
		{
			// Variables for collecting of some integer values
			string numbers;
			int[] result;

			// Ask the user for some integer values
			Console.WriteLine("Write some numbers and split them by coma: ");
			numbers  = Console.ReadLine();

			// Convert a string value into a array of integer values, then return result
			result = Array.ConvertAll(numbers.Split(","), int.Parse);
			return result;
		}
	}
}
