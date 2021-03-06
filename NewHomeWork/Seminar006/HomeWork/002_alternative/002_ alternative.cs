using System;

using static System.Console;

public class Program
{
	static public void Main()
	{

		/*

		Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
		b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
		*/


		double k1 = 5;
		double b1 = 2;
		double k2 = 9;
		double b2 = 4;

		double x1 = 0;
		double x2 = 0;

		double Ny = 0;
		double My = 0;


		FindXY();

		void FindXY()
		{
			string result = "nothing";
			for (double i = 0; i < double.MaxValue; i++)
			{
				Ny = k1 * x1 + b1;
				My = k2 * x1 + b2;

				if (Ny == My)
				{
					result = $"X {x1}, Y {Ny}";
					break;
				}
				x1 += 0.1;

				Ny = (k1 * x2 + b1);
				My = (k2 * x2 + b2);

				if (Ny == My)
				{
					result = $"X {x2}, Y {Ny}";
					break;
				}
				x2 -= 0.1;

			}
			Write(result);
		}

	}
}