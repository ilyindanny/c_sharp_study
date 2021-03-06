using System;
using static System.Console;
public class Program
{
	static public void Main()
	{


		// char и string


		// тип char. значение указывается в одинарных кавычках.


		char ch = '\u0080';  // это знак градуса
		WriteLine(ch);

		ch = (char)0x0080; // это второй способ вывести символ юникода
		WriteLine(ch);
		// или:
		ch = (char)176;
		WriteLine(ch);


		// а вот как получить код символа

		int i = (int)'°';
		WriteLine(i);

		// при конкатенации с другими типами char преобразуется либо в символы: 5 + 'a' - тут сложится 5 и юникод код буквы, либо преобразуется в строки: "a" + 'a'. Однако выражение 'a' + 'b' даст число 195.



		// string это неизменяемый (immutable) тип: нельзя ищменить символ в строке, можно создать новую строку с изменением.

		// по индексу можно обращаться непосредственно к литералу:

		i = 3;
		ch = "abcdefg"[i]; // вернет d.
		WriteLine(ch);

		ch = (char)('a' + i); // 1) при конкатенации складывается код буквы и значение переменной i, а потом служебное слово char преобразует код в букву. возвращается буква, которая по индексу больше, чем a, на число в переменной i
		WriteLine(ch);

		// обратиться к символу в массиве строк можно вторым указанием индекса:

		string[] astr = { "abc", "def", "ghi" };
		ch = astr[1][1]; // вернет e
		WriteLine(ch);
		// или еще короче:
		ch = (new string[] { "abc", "def", "ghi" }[1][1]);
		WriteLine(ch);


		// массив символов можно преобразовать в строку при помощи конструктора:

		char[] ach = { '1', '2', '3', '4', '5', '6' };
		string str = new string(ach);

		// у класса String есть метод, работающий наоборот, преобразуя строку в массив символов:

		char[] ach2 = str.ToCharArray();
		// этот же метод можно применять непосредственно к строковому литералу:
		char[] ach3 = "abcdefghi".ToCharArray();


		// пример создания строки с использованием конструктора (параметр после запятой указывпет количество символов и может быть выражением):

		str = new string('*', i);
		WriteLine(str);


		// у структуры Char есть методы, возвращающие true или false, если символ (или индекс в строке для перегруженного метода) цифра, буква, буква или цифра, строчная, заглавная, число (можно дробное), пунктуация и еще что-то

		bool b = Char.IsDigit("abcde", 2);

		b = Char.IsLetter("abcde", 2);
		b = Char.IsLetterOrDigit("abcde", 2);
		b = Char.IsLower("abcde", 2);
		b = Char.IsUpper("abcde", 2);
		b = Char.IsNumber("abcde", 2);
		b = Char.IsPunctuation("abcde", 2);
		b = Char.IsWhiteSpace("abcde", 2);

		WriteLine(b);


		// строки неизменяемые. но у класса String есть несколько методов для создания измененной строки

		// ToUpper и ToLower:

		str = "abcdefgh";
		str = str.ToUpper(); // или ToLower
		WriteLine(str);


		// SubString. назначает новой строке часть исходной строки:

		str = str.Substring(1, 2); // параметры могут быть заданы переменным. первый — индекс, второй — количество символов
		WriteLine(str);

		// метод StringFormat позволяет применить форматирование и вернуть строку:

		int A = 1, B = 2, C = A + B;
		str = String.Format("{0} + {2} = {1}", A, C, B);
		WriteLine(str);

	}
}
