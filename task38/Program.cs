// Задайте массив вещественных чисел.
//Найдите разницу между максимальным и минимальным элементов массива
Console.WriteLine("Введите длину массива");
int[] PrintArray = GetArray(int.Parse(Console.ReadLine()));
Console.WriteLine(String.Join(" ", PrintArray));
Console.WriteLine(FindMax(PrintArray) - FindMin(PrintArray));

int[] GetArray (int length)
{
  int[] array = new int[1];
  if (length <= 0)
  {
    array[0] = 0;
  }
  else
  {
    array = new int[length];
    for (int i = 0; i < length; i++)
    {
      array[i] = new Random().Next(0, 100);
    }
  }
  return array;
}

int FindMax (int[] array)
{
  int max = array[0];
  for (int i = 1; i < array.Length; i++)
  {
    if (array[i] > max)
    {
      max = array[i];
    }
  }
  return max;
}

int FindMin (int[] array)
{
  int min = array[0];
  for (int i = 1; i < array.Length; i++)
  {
    if (array[i] < min)
    {
      min = array[i];
    }
  }
  return min;
}
