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

				// Check if the user choise not to quit the program
				if (choise != 99)
				{
					// Create a empty console window then show the name of this program
					Console.Clear();
                    Console.WriteLine(ProgramName);

                    // Make a empty row
                    Console.WriteLine();

					// Take the user to the math function that user choise
					switch(choise)
					{
						case 1:
							Addition();
							break;
						case 2:
							Subtraction(); 
							break;
						case 3:
							Division(); 
							break;
						case 4:
							Multiplication();
							break;
						default:
							break;
					}

                    // Make a pause in this program
                    Console.ReadKey();
				}

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
		
		/// <summary>
		/// Calculate the sum and show the result in console window
		/// </summary>
		static void Addition()
		{
			// Show a header of this addition function
			ShowAHeader("Addition");

			// Variables for calculation of the sum
			int result = 0;
			int[] numbers = GetSomeInterger();

			// Calculate the sum and show the result in console window
			Console.Write("The sum of ");
			for(int x = 0; x < numbers.Length; x++) 
			{
				// Add value to result
				result += numbers[x];

				// Show the value added to result for the user
				Console.Write(numbers[x]);
				if (x < numbers.Length - 1)
					Console.Write(", ");
			}
			Console.WriteLine($" are {result}.");
		}
		/// <summary>
		/// Calculate the difference and show the result in console window
		/// </summary>
		static void Subtraction()
		{
			// Show a header of this subtraction function
			ShowAHeader("Subtraction");

			// Variables for calculation of difference
			int result = 0;
			int[] numbers = GetSomeInterger();

			// Calculate the difference and show the result in console window
			Console.Write("The difference from ");
			for (int x = 0; x < numbers.Length; x++)
			{
				// Check if the number are 1:st one, then set or reduce value to result
				if (x == 0)
					result = numbers[x];
				else
					result -= numbers[x];

				// Show the value that set or reduce result
				Console.Write(numbers[x]);
				if(x  < numbers.Length - 1)
					Console.Write(", ");
			}
			Console.WriteLine($" are {result}.");
		}
		/// <summary>
		/// Calculate the qouta from two integer and show the result in console window
		/// </summary>
		static void Division()
		{
			// Show a header for this division function
			ShowAHeader("Division");

			// Variables for calculation of qouta
			int a, b;

			// Ask the user for two integer
			Console.Write("Write a number: ");
			int.TryParse(Console.ReadLine(), out a);

			Console.Write("Write a other number and it don't are zero: ");
			int.TryParse( Console.ReadLine(), out b);

			// Check if the 2:nd number are zero
			if (b == 0)
				Console.WriteLine("The secord number are zero and didn't allowed be that.");
			else
				Console.WriteLine($"The qouta from {a} and {b} are {a / b}.");
		}
		/// <summary>
		/// Calculate the product from two integer and show the result in console window
		/// </summary>
		static void Multiplication()
		{
			// Show a header for this multiplication function
			ShowAHeader("Multiplication");

			// Variables for calculate the product
			int a, b;

			// Ask the user for two integer 
			Console.Write("Write a number: ");
			int.TryParse(Console.ReadLine(), out a);

			Console.Write("Write a other number: ");
			int.TryParse(Console.ReadLine(), out b);

			// Calculate the product and show the result in console window
			Console.WriteLine($"The product of {a} and {b} are {a * b}.");
		}
	}
}
