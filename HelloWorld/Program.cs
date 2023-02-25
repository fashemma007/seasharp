using System;
public class Program
{
	/// <summary>
	/// Playing around
	/// </summary>
	/// <param name="args"></param>
	public static void Main(string[] args)
	{
		int age = GetAge(2, 1995);
		Console.WriteLine("You're " + age + " years old");
	}
	/// <summary>
	/// Calculates the age of a user
	/// </summary>
	/// <param name="month">Month of birth</param>
	/// <param name="year">Year of Birth</param>
	public static int GetAge(byte month, int year)
	{
		int thisYear = 2023;
		int thisMonth = 2;
		var age = (((thisYear * 12) + thisMonth) - (year * 12 + (month))) / 12;
		return age;
	}
}