// Предполагается сделать игру где ИИ будет загадывать число, а человек отгадывать это число



using System.Runtime.CompilerServices;

Console.Clear();

Console.WriteLine("Меня зовут Антошка, я являюсь ИИ.");
Console.WriteLine("Тебя как зовут?: ");
string Name = Console.ReadLine();
Console.WriteLine($"Привет {Name}");
Console.WriteLine();

Console.WriteLine($"{Name} , я хотел бы поиграть с тобой  в занимательную игру, ты согласен? Для продолжения нажми Enter, для выхода нажми 'q и Enter'");

// Здесь должен обрабатываться запрос на ввод Да/Нет, но этого мы делать не будем. При нажатии "ENTER" игра продолжается

string positiveAnsver = Console.ReadLine();


Console.WriteLine("Отлично, давай начнем!!! Я буду загадывать число от 1 до 5, а ты отгадывай. Есть одно НО, у тебя три попытки. Поехали :)");



int user_Step = 3;

while (user_Step > 0)
{
    Console.WriteLine("");  // Число игрока
    int numA = int.Parse(Console.ReadLine());
    Random rnd = new Random();   // Загаданное число Алешкой
    int numB = rnd.Next(1, 10);
    Console.WriteLine("Твое число: " + numA);

    if (numA == numB)
    {
        Console.WriteLine("Поздравляю, я загадал число: " + numB);
        break;
    }
    else
    {
        Console.WriteLine("Не угадал, попробуй еще раз");
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