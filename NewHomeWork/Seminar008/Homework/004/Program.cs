//
/*
Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
массив размером 2 x 2 x 2
12(0,0,0) 22(0,0,1)
45(1,0,0) 53(1,0,1)
*/

using System;
using static System.Console;
public class Program
{
	static public void Main()
	{
		int[,,] array = GetArray(2, 2, 2);
		ShuffleArray(array);
		PrintArray(array);


		int[,,] GetArray(int rows, int columns, int depth)
		{
			int item = 10;

			int[,,] array = new int[rows, columns, depth];
			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < columns; j++)
				{
					for (int k = 0; k < depth; k++)
					{
						array[i, j, k] = item++;
					}
				}
			}
			return array;
		}
		
		
		void ShuffleArray(int[,,] array)
		{
			int x;
			int y;
			int z;
			int temp;

			for(int i = 0; i < array.GetLength(0); i++)
			{
				for(int j = 0; j < array.GetLength(1); j++)
				{
					for(int k = 0; k < array.GetLength(2); k++)
					{
						x = new Random().Next(0, array.GetLength(0));
						y = new Random().Next(0, array.GetLength(1));
						z = new Random().Next(0, array.GetLength(2));
						temp = array[i, j, k];
						array[i, j, k] = array[x, y, z];
						array[x, y, z] = temp;
					}
				}
			}
		}


		void PrintArray(int[,,] array)
		{
			for (int i = 0; i < array.GetLength(0); i++)
			{
				for (int j = 0; j < array.GetLength(1); j++)
				{
					for (int k = 0; k < array.GetLength(2); k++)
					{
						Write("{0, 5}({1},{2},{3})", array[i, j, k], i, j, k);
					}
					WriteLine("\n");
				}
				
			}
		}
	}
}