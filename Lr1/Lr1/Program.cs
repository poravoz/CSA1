using System;
using System.IO;
using System.Runtime.CompilerServices;

public class DisplayMenu
{
	public string? choice;

	public void menu()
	{
		Console.WriteLine("Choose 1 or 2");
		Console.WriteLine("if you pick 1 this is reading a Lorem file");
		Console.WriteLine("if you pick 2 this is a calculate two sum ");
		
		do
		{
			Console.Write("Enter the number: ");
			choice = Console.ReadLine();

			switch (choice)
			{
				case "1":
					Console.Write("\n");
					ReadFile readFile = new ReadFile();
					readFile.readFile();
					break;
				case "2":
					Console.Write("\n");
					Calculate calculate = new Calculate();
					Console.WriteLine(calculate.Sum());
					break;
				default:
					Console.Write("\n");
					Console.WriteLine("Error Please Choose 1 or 2");
					break;
			}
		} while (choice != "1" && choice != "2");
	}
}

public class ReadFile
{
	public int number;

	public void readFile()
	{
		Console.Write("Enter the number: ");
		try
		{
			number = Convert.ToInt32(Console.ReadLine());

			StreamReader streamReader = new StreamReader("C:\\Users\\Жанна\\Documents\\GitHub\\OTHER\\CSA1\\Lr1\\loremIpsum.txt");
			string fileContent = streamReader.ReadToEnd();
			fileContent.Split(" ");

			int count = 0;
			for (int i = 0; i < fileContent.Length; i++)
			{
				if (fileContent[i] == ' ')
				{
					count++;
				}
				else if (count == number)
				{
					break;
				}
				Console.Write(fileContent[i]);
			}
			Console.Write("\n");


		}
		catch (Exception e)
		{
			Console.WriteLine("Exception: " + e.Message);
		}
	}
}



public class Calculate
{
	int result = 0;
	public int Sum()
	{
		Console.Write("Enter value1: ");
		int value1 = Convert.ToInt32(Console.ReadLine());

		Console.Write("Enter value2: ");
		int value2 = Convert.ToInt32(Console.ReadLine());

		return result = value1 + value2;
	}
}



namespace Lr1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DisplayMenu displayMenu = new DisplayMenu();
			displayMenu.menu();
		}
	}
}
