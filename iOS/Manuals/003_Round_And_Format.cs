using System;
using static System.Console;

public class Program
{
	static public void Main()
	{

		//*********************************************
		// в строковом литерале символ кавычки ставится двумя способами:

		// 1) "дословная строка". символ @ перед строковым литералом и дублированные кавычки. в таком случае обратный слэш (символ управляющей последовательности) в строке обрабатывается как и остальные символы

		// 2) "символ управляющей последовательности". обратный слэш \ перед каждой кавычкой


		WriteLine(@"ab ""c"" d");

		WriteLine("ab \"c\" d");


		// округление внутри скобок: $"{a:F3}"

		double a = -4.456;
		WriteLine($"{a:F3}");


		// округление в вычислении. в скобках метода Round после выражения задается через запятую порядок округления (второй аргумент может принимать значения до 28):

		double result = Math.Round(a * a, 2);
		WriteLine(result);


		// округление для Decimal. методы статические, поэтому указывается структура:

		// Truncate и Floor по-разному округляют отрицательные числа. Truncate округляет отрицательное число в сторону нуля, а Floor округляет в сторону отрицательной бесконечности.

		decimal b = Decimal.Truncate((decimal)a);
		WriteLine(b);
		b = Decimal.Floor((decimal)a);
		WriteLine(b);


		// метод Round, вызываемый структурой Decimal. характерно, что для чисел, находящихся ровно между двумя возможностями округления, работает принцип "банковское округление" или "округление до четного", то есть 2,35 и 2,45 округлятся до 2,4, потому что 2,4 - ближайшее четное число:

		b = 2.35m;
		b = Decimal.Round(b, 1);
		WriteLine(b);


		// для округления чисел, находящихся ровно между двумя возможностями округления, в большую сторону (и с сохранением именно двух порядков после запятой) используется следующая формула:

		decimal c = 8.345m;
		b = Decimal.Truncate(c * 100 + 0.5m) / 100; // умножение на 100 сдвигает точку на два знака и метод Truncate их уже не округлит. прибавление 0.5m позволяет получить округление вверх от пятерки. потом уже окргугленное число обратно делится на сто и таким образом появляются два знака за точкой, но с округленным результатом в последней цифре

		WriteLine($"{c} and {b}");




		// метод ToString может иметь аргументы, позволяющие применить форматирование к возвращаемому литералу. в зависимости от аргумента цифра за ним обозначает разное. например, P2 вернет проценты с двухзначной точностью. таблица параметров в книге C# Петцольда стр 129:

		decimal m = 12345.345m;
		string s = m.ToString("P2");
		WriteLine(s);


		// также возможно округление. причем в данном случае округление производится до большего числа:

		s = m.ToString("F") + "rounded";
		WriteLine(s);


		// или числовой формат с тремя десятичными знаками (по умолчанию два знака после запятой):

		s = m.ToString("N3") + " rounded";
		WriteLine(s);


		// возможна потеря точности, если указать всего два десятичных разряда:

		s = m.ToString("E2") + " rounded";
		WriteLine(s);


		// еще немного форматирования. два оператора возвращают одинаковые результаты (спецификация форматирования указывается без пробела):

		WriteLine("text {0:E4} + {0:E4} is {2:E4}", m, b, m + m);

		WriteLine("text {0} + {0} is {2}", m.ToString("E4"), b, m.ToString("E4") + m.ToString("E4"));


		// а вот как задать количество пробелов для поля, чтобы было либо число, либо пробелы вместо него. литерал выравнивается по правому краю (либо по левому, если используется отрицательное значение длины поля:

		WriteLine("text {0, 14} + {0, -14} is {2, 15}", m, b, m + m);

		// форматирование поля сочетается со спецификациями форматирования:

		WriteLine("text {0, 14:N2} + {0, -14:N2} is {2, 15:E4}", m, b, m + m);

	}
}
