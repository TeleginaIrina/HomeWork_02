// Задача 10: Показать вторую цифру трёхзначного числа.
int GetRandom()
{
    int number = new Random().Next(100,1000);
    return number;
}
int randomazer = GetRandom();
Console.WriteLine($"Случайное число: {randomazer}");
int result = randomazer % 100 / 10;
Console.WriteLine($"Вторая цифра трёхзначного числа = {result}");


