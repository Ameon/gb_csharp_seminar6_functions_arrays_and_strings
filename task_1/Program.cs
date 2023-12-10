// Задача 1:
//  Создайте двумерный массив символов (тип char [,]) 
//  и сформируйте из него строку.

using System.Text;

Console.Write("Введите размеры матрицы: ");
string? input = Console.ReadLine()?.Trim();

if (input == null)
{
  Console.WriteLine("Ошибка: не был получен ввод.");
  return;
}

int[] size = input.Split(" ").Select(x => int.Parse(x)).ToArray();
char[,] charMatrix = new char[size[0], size[1]];

InputMatrix(charMatrix);
Console.WriteLine("Исходная матрица символов:");
PrintMatrix(charMatrix);

string resultString = MatrixToString(charMatrix);
Console.WriteLine("Строка, сформированная из матрицы символов:");
Console.WriteLine(resultString);

void InputMatrix(char[,] matrix)
{
  Random random = new Random();
  for (int i = 0; i < matrix.GetLength(0); i++)
    for (int j = 0; j < matrix.GetLength(1); j++)
      matrix[i, j] = (char)random.Next('a', 'z' + 1);
}

void PrintMatrix(char[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
      Console.Write(matrix[i, j] + " ");
    Console.WriteLine();
  }
}

string MatrixToString(char[,] matrix)
{
  StringBuilder sb = new StringBuilder();
  for (int i = 0; i < matrix.GetLength(0); i++)
    for (int j = 0; j < matrix.GetLength(1); j++)
      sb.Append(matrix[i, j]);
  return sb.ToString();
}

