// Задача НЕГАФИБОНАЧЧИ. Задайте число. Составьте список чисел НегаФибоначчи, в том числе для отрицательных индексов.
// *Пример:*
// - для k = 8 список будет выглядеть так: [-21 ,13, -8, 5, −3, 2, −1, 1, 0, 1, 1, 2, 3, 5, 8, 13, 21]


int[] Fibon(int N)
{
  int[] array = new int[N * 2 + 1];
  array[N - 1] = 1;
  array[N] = 0;
  array[N + 1] = 1;
  for (int i = N - 2; i >= 0; i--)
    array[i] = array[i + 2] - array[i + 1];
  for (int i = N + 2; i < N * 2 + 1; i++)
    array[i] = array[i - 1] + array[i - 2];
  return array;
}


void PrintArray(int[] array)
{
  Console.Write("\n[ ");
  foreach (var el in array)
    Console.Write($"{el} ");
  Console.WriteLine("]");
}


Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = Fibon(N);
PrintArray(array);