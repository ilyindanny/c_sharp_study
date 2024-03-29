﻿using System;

using static System.Console;

public class Program
{

	static public void Main()
	{

		// вычисление глубины шкафа при условии заданной высоты шкафа
		// вычисление расстояния по горизонтали от точки на стене до точки на дуге открывания люка (задается расстояние от потолка, то есть длинна катета по вертикали):

		double dR = 1000; // радиус дуги
		double dCathetB = 638; // катет (по вертикали)
		double dCathetA = Math.Sqrt(dR * dR - dCathetB * dCathetB); // возвращает длинну катета по горизонтали

		double dDepthSize = 400 + dR - dCathetA; // вычисление расстояния от точки на стене до точки на дуге (по горизонтали) 400 - это расстояние от стены до люка

		WriteLine("depth size of wardrobe = {0:N2}", dDepthSize);



		// вычисление необходимой высоты шкафа, при условии заданной глубины шкафа.

		dDepthSize = 650;
		dCathetA = dR + 400 - dDepthSize;
		dCathetB = Math.Sqrt(dR * dR - dCathetA * dCathetA);

		WriteLine("size from wardrobe to ceiling = {0:N2}", dCathetB);


		// вычисление угла открывания люка при условии, что петли со стороны шкафа

		dDepthSize = 650;
		dCathetB = 250;
		dCathetA = dDepthSize - 400;

		double dHypotenuse = Math.Sqrt(dCathetB * dCathetB + dCathetA * dCathetA); // вычисление гипотенузы треугольника


		WriteLine((Math.Asin(dCathetB / dHypotenuse) * (180 / Math.PI)));

	}
}