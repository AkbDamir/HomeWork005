/*Задача 36: Задайте одномерный массив, 
заполненный случайными числами. 
Найдите сумму элементов, 
стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

void FillArr(int[] arr)
{
    int count = arr.Length;
    int index = 0;
    while (index < count)
    {
        arr[index] = new Random().Next(-100, 100);
        index++;
    }
}
void PrintArr(int[] arr)
{
    int count = arr.Length;
    for(int i = 0; i < count; i++)
    {
        Console.Write(arr[i] + " ");
    }
}
void PrintEvenIndexSum(int[] arr)
{
    int count = arr.Length;
    int sum = 0;
    for(int i = 1; i < count; i += 2)
    {
        sum += arr[i];
    }
    Console.Write("Сумма элементов на нечетных позициях равна " + sum);
}

int[] array = new int[10];
FillArr(array);
PrintArr(array);
PrintEvenIndexSum(array);