using System;
using static System.Console;
public class Program
{
    static public void Main ()
    {
		// метод не изменяет переменную, переданную ему в виде аргумента. другими словами, метод изменяет параметр, но не изменяет аргумент. но если параметр сам относится к типу, представляющему собой ссылку, метод может изменить исходный объект.
		// если нужно изменить переменную, то аргумент метода объявляется как параметр-ссылка с ключевым словом ref (также и при вызове метода нужно указывать ключевое слово перед именем переменной в аргументе метода):
	
       int numA = 5;
		ChangeNumA(ref numA);
		WriteLine(numA);
		
		void ChangeNumA(ref int i)
		{
			i = 25;
		}
		
		// похожее ключевое слово - out. но с этим ключевым словом можно передавать методу в качестве аргумента не инициализированные переменные (но параметр out должен быть обязательно установлен методом):
		
		int numB;
		SetNumB(numA, out numB);
		WriteLine("numA = {0}, numB = {1}", numA, numB);
		
		void SetNumB(int i, out int j)
		{
			j = ++i; // если в методе указать ref int i, то i тоже изменится в следсвие инкремента ++i
		}
		
		
		// а вот, кстати, способ обмена значениями целочисленных переменных без дополнительной переменной: 
		
		int a = -3;
		int b = 2;
		
		a = a + b;
		b = (b - a) * -1;
		a = a - b;
		WriteLine("a = {0}, b = {1}", a, b);
		
    }
}
