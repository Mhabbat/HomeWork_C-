
//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 3, 5 -> 243 (3⁵)
/*
void NumDegree (int a,int b)
{
    int result = 1;
    for(int i = 1; i<=b; i++)
    {
        result *= a;
    }
Console.WriteLine($"{a} extent  {b} = {result}");
}
Console.Write("Input a number:a ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number:b ");
int numberB=Convert.ToInt32(Console.ReadLine());
 NumDegree(numberA,numberB);

/*   Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


Console.Write("Input a number: ");
int numberA = Convert.ToInt32(Console.ReadLine());

int SumNumber (int numberA )
{
    int result = 0;
    while(numberA > 0)
    {
        result+= numberA % 10;
        numberA =numberA / 10; 
    }
    return result;
} 

  int sumNumber = SumNumber(numberA);
Console.WriteLine("Сумма цифр в числе: " + sumNumber);


   
/*Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] */

/*
  int [] CreateArray(int size)
{
    int[] array = new int [size];
    for(int i = 0; i < size; i++)
    {
       Console.Write($"Введите {i + 1} элемент: ");
       array[i] = Convert.ToInt32(Console.ReadLine()); 
    }
      

      return array;  
}

void ShowArray(int[] array)


{
    for(int i = 0; i < array.Length; i++)
    {
    Console.Write(array[i] + " ");
  
Console.WriteLine();
    }
}

Console.Write("Введите длина массива: ");
int length = Convert.ToInt32(Console.ReadLine());

    
int [] newArray = CreateArray (length);
ShowArray(newArray);
*/