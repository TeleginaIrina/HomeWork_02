// Задача 16: Дано число обозначающее день недели. Выяснить является номер дня недели выходным


string numberStr = String.Empty;
int number = 0;
while(number <= 0 || number >= 8)
{
    Console.Write("Введите число от 1 до 7: ");
    numberStr = Console.ReadLine();
    int.TryParse(numberStr, out number);
}
string[] nameweek = {"monday", "tuesday", "wednesday", "thursday", "friday", "saturday", "sunday"};

if (number < 6)
    Console.WriteLine($"Будний день {nameweek[number - 1]}");
else 
    Console.WriteLine($"Выходной день {nameweek[number - 1]}");
