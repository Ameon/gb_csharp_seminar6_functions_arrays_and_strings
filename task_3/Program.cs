// Задача 3:
//  Задайте произвольную строку и определите, является ли она палиндромом.

using System.Text;

Console.Write("Введите строку: ");
string? originalString = Console.ReadLine();

if (string.IsNullOrEmpty(originalString))
{
  Console.WriteLine("Ошибка: не был получен ввод.");
  return;
}

string processedString = RemoveSpecialCharacters(originalString.ToLower());
bool isPalindrome = processedString == new string(processedString.Reverse().ToArray());

Console.WriteLine($"\"{originalString}\" => {(isPalindrome ? "да" : "нет")}");

string RemoveSpecialCharacters(string str)
{
  StringBuilder sb = new StringBuilder();
  foreach (char c in str)
  {
    if (char.IsLetterOrDigit(c))
    {
      sb.Append(c);
    }
  }
  return sb.ToString();
}