//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2
/*Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Вот наш массив: ");
ShowArray(numbers);

int count = 0;
for (int i = 0; i < numbers.Length; i++)
if (numbers[i] % 2 == 0)
count++;

Console.WriteLine($"всего {numbers.Length} чисел, {count} из них чётные");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next (100,1000);
    }
}
void ShowArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}  */




//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0
/*
int [] CreateArray(int size, int minValue, int maxValue){
    int [] array = new int[size];
    for(int i=0; i<size; i++){
        array[i] = new Random().Next(minValue, maxValue+1);
    }
    return array;
}

void ShowArray(int [] array){
    Console.Write("[ ");
    for(int i = 0; i<array.Length; i++){
        Console.Write($"{array[i]} ");
    }
    Console.Write("]");
    Console.WriteLine();
}


int CountNumberSegment(int [] array){
    int summ = 0;
    for(int i = 0; i< array.Length; i++){
       if(array[i] %2 !=0)
       summ += array[i];
            
    }
    return summ;
}
int size = 10;
int min = -1;
int max = 99;
int [] createdArray = CreateArray(size, min, max);
Console.WriteLine("Here is our array");
ShowArray(createdArray);
Console.WriteLine($"Sum is negative numbers: {CountNumberSegment(createdArray)}");   */


//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76
int Find_Min_Max_diff(int[] array)
            {
                int result = 0;
                int min = 0;
                int max = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[min] > array[i])
                        min = i;
                    else if (array[max] < array[i])
                        max = i;
                }
                Console.WriteLine("min= " + array[min] + "\tmax= " + array[max]);
                if (array[min] > array[max])
                    result = array[min] - array[max];
                else if (array[max] > array[min])
                    result = array[max] - array[min];
                return result;
            }
            Console.Write("введите размер массива: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];
            Console.Write("введите минимальное значение: ");
            int Min = Convert.ToInt32(Console.ReadLine());
            Console.Write("введите максимальное значение: ");
            int Max = Convert.ToInt32(Console.ReadLine());
            int temp = 0;
            if (Min > Max)
            {
                temp = Max;
                Max = Min;
                Min = temp;
            }
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
                array[i] = rand.Next(Min, Max);
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + "\t");
            

            Console.WriteLine("разница между минимальным и максимальным элементом массива=" + Find_Min_Max_diff(array));
  