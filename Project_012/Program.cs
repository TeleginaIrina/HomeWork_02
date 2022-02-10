// Задача 12: Удалить вторую цифру трёхзначного числа.
int GetRandom()
{
    int number = new Random().Next(100,1000);
    return number;
}
int randomazer = GetRandom();
Console.WriteLine($"Случайное число: {randomazer}");

int resultOne = randomazer / 100;
int resultTwo = randomazer % 10;

Console.WriteLine($"{resultOne}.{resultTwo}");

