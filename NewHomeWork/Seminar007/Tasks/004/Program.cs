﻿//
/*******************************************
задать двумерный массив
посчитать сумму элементов, стоящих на главной диагонали

********************************************/


// для не квадратных массивов нужна была бы проверка, и по меньшей стороне выставлялся бы счетчик:
// int length = array.GetLength(0) > array.GetLength(1) ? array.GetLength(1) : array.GetLength(0);

using System;
using MyClasses;
using static System.Console;
using System.Linq;
class Program
{
	static void Main()
	{
		int n = int.Parse(ReadLine()!);

		// первая группа методов для создания массива, подсчета суммы элементов по диагонали (СОЕДИНЯЮЩЕЙ МАКСИМАЛЬНЫЕ ИНДЕКСЫ),
		// вывода на экран и последующей заменой остальных элементов нулями и снова выводом на экран

		WriteLine("first method");

		int[,] numArray = MyMethods.GetArray(n);
		int sumOfDiagonal = MyMethods.SumOfDiagonal(numArray);
		MyMethods.PrintArray(numArray);

		WriteLine(sumOfDiagonal);
		numArray = MyMethods.ChangeByNull(numArray);
		MyMethods.PrintArray(numArray);

		// вторая группа методов для создания массива, подсчета суммы элементов по диагонали-биссектрисе (ИДУЩЕЙ ОТ НУЛЯ),
		// вывода на экран и последующей заменой остальных элементов нулями и снова выводом на экран

		WriteLine();
		WriteLine("second method");

		numArray = MyMethods.GetArray(n);
		int sumOfDiagonalBisector = MyMethods.SumOfDiagonalBisector(numArray);
		MyMethods.PrintArray(numArray);

		WriteLine(sumOfDiagonalBisector);
		numArray = MyMethods.ChangeByNullBisector(numArray);
		MyMethods.PrintArray(numArray);



	}
}

public class MyMethods
{
	/// <Summary>
	/// создание двумерного массива (квадрат с одинаковыми сторонами)
	/// </Summary>
	public static int[,] GetArray(int length)
	{
		int[,] array = new int[length, length];
		for (int i = 0; i < length; i++)
		{
			for (int j = 0; j < length; j++)
			{
				array[i, j] = new Random().Next(1, 10);
			}
		}
		return array;
	}


	/// <Summary>
	/// подсчет суммы элементов массива, стоящих на основной диагонали
	/// </Summary>
	public static int SumOfDiagonal(int[,] array)
	{
		int result = 0;
		int length = array.GetLength(0);
		for (int i = 0; i < length; i++)
		{
			result += array[i, length - i - 1];
		}
		return result;
	}


	/// <Summary>
	/// подсчет суммы элементов массива, стоящих на диагонали-биссектрисе
	/// </Summary>
	public static int SumOfDiagonalBisector(int[,] array)
	{
		int result = 0;
		int length = array.GetLength(0);
		for (int i = 0; i < length; i++)
		{
			result += array[i, i];
		}
		return result;
	}


	/// <Summary>
	/// замена значений в массиве на нули всех элементов, кроме находящихся на основной диагонали
	/// </Summary>
	public static int[,] ChangeByNull(int[,] array)
	{
		int length = array.GetLength(0);
		for (int i = 0; i < length; i++)
		{
			for (int j = 0; j < length; j++)
			{
				array[i, j] = j == length - i - 1 ? array[i, j] : 0;
			}
		}
		return array;
	}


	/// <Summary>
	/// замена значений в массиве на нули всех элементов, кроме находящихся на диагонали-биссектрисе
	/// </Summary>
	public static int[,] ChangeByNullBisector(int[,] array)
	{
		int length = array.GetLength(0);
		for (int i = 0; i < length; i++)
		{
			for (int j = 0; j < length; j++)
			{
				array[i, j] = j == i ? array[i, j] : 0;
			}
		}
		return array;
	}


	/// <Summary>
	/// вывод на экран двумерного массива
	/// </Summary>
	public static void PrintArray(int[,] array)
	{
		for (int i = 0; i < array.GetLength(0); i++)
		{
			for (int j = 0; j < array.GetLength(1); j++)
			{
				Write("{0, 3}", array[i, j]);
			}
			WriteLine();
		}
	}
}
