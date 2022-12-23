/* 
Урок 2. Базовые алгоритмы
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.*/
 

/*
Console.WriteLine("Введите трехзначное число:");
int number=Convert.ToInt32(Console.ReadLine());
int x=10;
int result = number / x;
Console.WriteLine(result % x);
*/

/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6 */
/*

int NumThird(int num)
{
    while(num > 1000)
    {
        num = num /10;
    }
    num =num % 10;
    return num;
}
Console.Write("Введите число:");
int num2 =
Convert.ToInt32(Console.ReadLine());
if (num2<100)
{
    Console.WriteLine("третьей цифра нет");
}
else
Console.WriteLine("Третья цифра этого числа:" + NumThird(num2));
*/


//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

/*
Console.WriteLine("Введите число неделя");
int number=Convert.ToInt32(Console.ReadLine());
int a=6;
int b=7;

if(number ==a)
{
    Console.WriteLine("Этот день выходной.");
}
if(number ==b)
{
    Console.WriteLine("Этот день выходной.");
}
else
{
 Console.WriteLine("Это будни день");
}
*/
