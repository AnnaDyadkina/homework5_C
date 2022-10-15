// Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях.
Console.WriteLine("Введите длину массива");
int[] PrintArray = GetArray(int.Parse(Console.ReadLine()));
Console.WriteLine(String.Join(" ", PrintArray));
Console.WriteLine(SumEvenPosition(PrintArray));

int[] GetArray (int length)
{
  if (length < 0)
  {
    length = 0;
  }
  int[] array = new int[length];
  for (int i = 0; i < length; i++)
  {
    array[i] = new Random().Next(-100, 101);
  }
  return array;
}

int SumEvenPosition (int[] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (i % 2 != 0)
    {
      count = count + array[i];
    }
  }
  return count;
}
