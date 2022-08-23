/*Задача 34: Задайте массив заполненный 
случайными положительными трёхзначными числами. 
Напишите программу, 
которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/


void RandomArr(int[] random)
{
    int count = random.Length;
    int pos = 0;
    while (pos < count)
    {
        random[pos] = new Random().Next(1, 999);
        pos++;
    }
}
void PrintArr(int[] arr)
{
    int count = arr.Length;
    int pos = 0;
    while (pos < count)
    {
        Console.Write(arr[pos] + " ");
        pos++;
    }
}
void PrintEven(int[] arrEven)
{
    int count = arrEven.Length;
    int pos = 0;
    int sum = 0;
    while (pos < count)
    {
        if (arrEven[pos] % 2 == 0)
        {
            sum++;
        }
        pos++;
    }
    Console.Write("количество четных чисел равно " + sum);
}

int[] array = new int[15];
RandomArr(array);
PrintArr(array);
PrintEven(array);