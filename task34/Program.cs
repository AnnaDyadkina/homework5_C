// Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.

Console.WriteLine("Введите длину массива");
int[] PrintArray = GetArray(int.Parse(Console.ReadLine()));
Console.WriteLine(String.Join(" ", PrintArray));
Console.WriteLine(SumEven(PrintArray));

int[] GetArray (int length)
{
  if (length < 0)
  {
    length = 0;
  }

  int[] array = new int[length];
  for (int i = 0; i < length; i++)
  {
    array[i] = new Random().Next(100, 1000);
  }
  return array;
}

int SumEven (int[] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] % 2 == 0)
    {
      count = count + 1;
    }
  }
  return count;
}
