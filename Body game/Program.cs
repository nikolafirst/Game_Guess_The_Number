// Предполагается сделать игру где ИИ будет загадывать число, а человек отгадывать это число



using System.Runtime.CompilerServices;

Console.Clear();

Console.WriteLine("Привет, я ИИ");

Console.WriteLine("Как тебя зовут?: ");

string Name = Console.ReadLine();

Console.WriteLine($"Привет \t{Name}");

Console.WriteLine();

Console.WriteLine($"{Name} , я хотел бы поиграть с тобой  в занимательную игру, ты согласен? (Для продолжения нажми Enter)");

string positiveAnsver = Console.ReadLine();

Console.WriteLine("Отлично, давай начнем!!! У тебя есть три попытки :)");
Console.WriteLine("");
Console.WriteLine("Понали!!!");


int user_Step = 3;

while (user_Step > 0)
{
    Console.WriteLine("");  // Число игрока
    int numA = int.Parse(Console.ReadLine());
    Random rnd = new Random();   // Загаданное число ИИ
    int numB = rnd.Next(1, 10);
    Console.WriteLine("Твое число: " + numA);

    if (numA == numB)
    {
        Console.WriteLine("Поздравляю, я загадал число: " + numB);
        break;
    }
    else
    {
        Console.WriteLine("Нет, не угадал");
        user_Step--;  // После каждой неудачной  попытки минус одна попытка
    }


}

if (user_Step == 0)
{
    Console.WriteLine();
    Console.WriteLine("Очень жаль, твои попытки закончились :((");
}

Console.WriteLine();
Console.WriteLine("---------------------------------------------");
Console.WriteLine("-------------- GAME OVER --------------------");
Console.WriteLine("---------------------------------------------");