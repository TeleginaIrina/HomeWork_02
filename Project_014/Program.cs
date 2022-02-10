// Задача 14: Найти третью цифру числа или сообщить, что её нет
int GetRandom()
{
    int number = new Random().Next(0,1000);
    return number;
}
int randomazer = GetRandom();
Console.WriteLine($"Случайное число: {randomazer}");
int result = randomazer / 10;
if (result >= 10)
{
    Console.WriteLine(randomazer % 10);
}
else
{
    Console.WriteLine("3 цифры нет");
}
