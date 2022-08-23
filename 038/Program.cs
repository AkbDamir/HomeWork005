/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным 
и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/
static int MaxNumberArray(int[] array)
{
    int max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}
static int MinNumberArray(int[] array)
{
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}
void FillArr(int[] array)
{
    int count = array.Length;
    for(int i = 0; i <count; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
}
void PrintArr(int[] array)
{
    int count = array.Length;
    for(int i = 0; i <count; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int[] array = new int[5];
int sums = 0;

FillArr(array);
PrintArr(array);
sums = MaxNumberArray(array) - MinNumberArray(array);

Console.Write("разница между максимальным и минимальным числами массива равна " + sums);
