double[] GetArray(int size)
{
  double[] result = new double[size];
  for (int i = 0; i < size; i++)
  {
    result[i] = Math.Round(new Random().NextDouble() * 10, 2);
  }
  return result;
}
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = GetArray(size);
double max = array[0];
double min = array[0];
for (int i = 0; i < size; i++)
{
  if (max < array[i])
  {
    max = array[i];
  }
  if (min > array[i])
  {
    min = array[i];
  }
}
double result = Math.Round(max - min, 2);
Console.WriteLine($"Массив [ {String.Join("\t", array)} ] разница между максимальным элементом {max} и минимальным элементом {min} равна {result} ");