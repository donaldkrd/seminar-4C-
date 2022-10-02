//Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
Console.Clear();
Console.Write("Введите число длины массива: ");
int lenArray = int.Parse(Console.ReadLine()!);

int[] randomArray = new int[lenArray];

for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(0, lenArray);
    Console.Write(randomArray[i] + " ");
}

