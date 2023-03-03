// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int Welcome(string message)
{
  Console.Write(message);
  int number = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine();
  return number;
}

void FillArray(int[] array, int number)
{
  Console.WriteLine($"Введите {number} - чисел массива:");
  for (int i = 0; i < array.Length; i++)
    array[i] = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine();
}

int CountPositive(int[] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] > 0)
      count++;
  }
  return count;
}

void PrintArray(int[] array)
{
  Console.Write("[ ");
  foreach (var el in array)
    Console.Write($"{el} ");
  Console.WriteLine("]");
}




try
{
  int n = Welcome("Введите размер массива: \t");
  int[] array = new int[n];
  FillArray(array, n);
  PrintArray(array);
  Console.WriteLine($"\nКоличество чисел больше нуля равно: - {CountPositive(array)}.");
}

catch
{
  Console.WriteLine("Были введены некорректные данные.");
}