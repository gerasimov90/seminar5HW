/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
которая покажет количество чётных чисел в массиве.


int[] GetArray(int size, int minV, int maxV)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minV, maxV + 1);
    }

    return array;
}

int[] resultArray = GetArray(6, 100, 999);
Console.WriteLine(String.Join("; ", resultArray));

int count = 0;

for (int i = 0; i < resultArray.Length; i++)
{
   if (resultArray[i] % 2 == 0) count++;
}
Console.WriteLine("Количество четных чисел в массиве: " + count);
*/

/*
Задача 36: Задайте одномерный массив, заполненный случайными
числами. Найдите сумму элементов, стоящих на нечётных позициях.
*/

int[] GetArray(int size, int minV, int maxV)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minV, maxV + 1);
    }

    return array;
}

int[] resultArray = GetArray(8, -99, 99);
Console.WriteLine(String.Join("; ", resultArray));

int sum = 0;

for (int i = 1; i < resultArray.Length; i = i+2)
{
   sum = sum + resultArray[i];
}
Console.WriteLine("Сумма нечетных элементов в массиве: " + sum);