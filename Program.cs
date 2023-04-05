/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" 
Console.Clear();
void ShowNums(int number)
{
  Console.Write(number +" ");
  if(number > 1) ShowNums(number - 1);
  
}
ShowNums(9);
*/

 /* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/
/*
int CalculateSumm(int m, int n)
		{
			int start = m;
			int end = n;
			if(m > n)
			{
				start = n;
				end = m;
			}
			return (end + start)*(end - start + 1)/2; // по формуле суммы членов арифметической прогрессии
		}
		Console.Write("Enter your m number: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter your n number: ");
        int n = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine(CalculateSumm(m,n));
*/

/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 
 static int Ack(int n,int m)
 {
  if (n == 0)
      return m +1;
      else
      if((n != 0) && (m == 0))
        return Ack(n - 1, 1);
        else
         return Ack(n - 1, Ack(n, m - 1));
 }
Ack(2,3); */








