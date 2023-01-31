// Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] num = new int[4];
int count = 0;

for (int i = 0; i < num.Length; i++)
{

    num[i] = new Random().Next(100, 999);

    if (num[i] % 2 == 0)
    {
        count++;
    }
}
string mas = string.Join(" ", num);
Console.Write(mas);
Console.Write($"->{count}");