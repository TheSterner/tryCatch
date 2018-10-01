using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryCatch
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> finalScores = new List<int> { 75, 85, 84, 79, 83, 92, 87, 78 };
			Console.WriteLine("Please pick a number to divide the list by.");
			int userNumber = Convert.ToInt32(Console.ReadLine());

			for (int i = 0; i < finalScores.Count; i++)
			{
				Console.WriteLine("Your number divided by each of the numbers in the list is " + finalScores[i] / userNumber);
			}
			Console.ReadLine();

			//2nd question. If you enter a non-zero number then it works as it should.
			//3rd question. If you divided by zero you get an Unhandled DividedByZero exception error.
			//4th question. If you enter in a string you get a Unhandled System.FormatException error.

			//5th question
			List<int> finalScores2 = new List<int> { 75, 85, 84, 79, 83, 92, 87, 78 };
			try

			{
				Console.WriteLine("Please pick a number to divide the list by.");
				int userNumber2 = Convert.ToInt32(Console.ReadLine());

				for (int i = 0; i < finalScores2.Count; i++)
				{
					Console.WriteLine("Your number divided by each of the numbers in the list is " + finalScores2[i] / userNumber2);
				}
				Console.ReadLine();
			}
			catch (FormatException ex)
			{
				Console.WriteLine("Please type a whole number.");
				return;
			}
			catch (DivideByZeroException ex)
			{
				Console.WriteLine("Please don't divide by zero.");
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			finally
			{
				Console.ReadLine();
			}
			Console.ReadLine();
		}
	}
}
