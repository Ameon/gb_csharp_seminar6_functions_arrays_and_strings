// Задача 2:
// Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.

Console.Write("Введите строку с латинскими буквами: ");
string? inputString = Console.ReadLine();

if (string.IsNullOrEmpty(inputString))
{
  Console.WriteLine("Ошибка: не был получен ввод.");
  return;
}

string lowerCaseString = inputString.ToLower();
Console.WriteLine($"\"{inputString}\" => \"{lowerCaseString}\"");