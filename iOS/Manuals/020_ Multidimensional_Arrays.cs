using System;

using static System.Console;

public class Program
{
	static public void Main()
	{

		// двумерные массивы

		//строки и столбцы нумеруются с нуля:

		//  0,0   0,1   0,2
		//  1,0   1,1   0,2
		//  2,0   2,1   2,2

		string[,] table = new string[5, 5];

		int[,] matrix = new int[5, 5];

		// так задается вручную:

		int[,] matrixPlus = new int[,]
		{
	{0,0,0},
	{0,0,0},
	{0,0,0}
		};

		// точно так же можно присвоить значение:

		table[1, 2] = "W";

		// количество строк возвращает метод GetLength(0):
		int rows = matrix.GetLength(0);

		// количество столбцов возвращает метод GetLength(1):
		int columns = matrix.GetLength(1);

		// распечатать при помощи метода (будет вложенный цикл):

		myProgram.PrintMatrix(matrix);


		// трехмерные массивы:

		string[,,] astrArray3D = new string[3, 2, 3]
		{
	{{"a", "b", "c"}, {"d", "e", "f"}},
	{{"g", "h", "i"}, {"j", "k", "l"}},
	{{"m", "n", "o"}, {"p", "q", "r"}},
		};

		WriteLine(astrArray3D[1, 1, 1] + " = k");



		// массивы массивов:

		string[][] astrArray = new string[3][]
		{
new string [] {"a", "b"},
new string [] {"c", "d"},
new string [] {"e", "f"}
		};

		WriteLine(astrArray[1][1] + " = d");


		// массив можно не объявлять, а выводить на жкран сразу в методе Write:

		int i = new Random().Next(1, 5);

		WriteLine(new string[] { "a", "b", "c", "d" }[i - 1]);


		// пример четырехмерного массива:

		int[,,,] ai4D = new int[5, 5, 5, 5];

		ai4D[2, 2, 2, 2] = 555;
		WriteLine(ai4D[2, 2, 2, 2] + " " + ai4D.Length + " " + ai4D.GetLength(3) + " " + ai4D.Rank);

	}
}




public class myProgram
{

	static public void PrintArray(string[,] matrix)
	{
		for (int i = 0; i < 5; i++)
		{
			for (int i2 = 0; i2 < 5; i2++)
			{
				Write(matrix[i, i2] + ".");
			}
			WriteLine("");
		}
	}



	static public void PrintMatrix(int[,] matrix)
	{
		for (int i = 0; i < matrix.GetLength(0); i++)
		{
			for (int j = 0; j < matrix.GetLength(1); j++)
			{
				Write(matrix[i, j] + " ");
			}
			WriteLine("");
		}
	}

}