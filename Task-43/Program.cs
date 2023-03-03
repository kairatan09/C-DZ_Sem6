// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


double Welcome(string message)
{
  Console.Write(message);
  double number = Convert.ToDouble(Console.ReadLine());
  Console.WriteLine();
  return number;
}

double[] InterPoint(double b1, double k1, double b2, double k2)
{
  double[] array = new double[2];
  array[0] = (b2 - b1) / (k1 - k2);
  array[1] = k1 * array[0] + b1;
  return array;
}

void PrintArray(double[] array)
{
  Console.Write($"({array[0]}; {array[1]})");
}


try
{
  double b1 = Welcome("Введите b1: \t");
  double k1 = Welcome("Введите k1: \t");
  double b2 = Welcome("Введите b2: \t");
  double k2 = Welcome("Введите k2: \t");
  double[] koord = InterPoint(b1, k1, b2, k2);
  Console.Write($"\nКоординаты точки пересечения двух прямых - ");
  PrintArray(InterPoint(b1, k1, b2, k2));
}

catch
{
  Console.WriteLine("Были введены некорректные данные.");
}