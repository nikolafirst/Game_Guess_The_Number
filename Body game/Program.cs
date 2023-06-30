// Предполагается сделать игру где ИИ будет загадывать число, а человек отгадывать это число



Console.WriteLine("Меня зовут Алешка, я являюсь ИИ. Тебя как зовут?: ");
string? Name = Console.ReadLine();
Console.WriteLine("");
Console.WriteLine($"Привет {Name}");

Console.WriteLine("Я хочу поиграть с тобой в занимательную игру, ты согласен? ДА/НЕТ");

// Здесь должен обрабатываться запрос на ввод Да/Нет, но этого мы делать не будем. При нажатии "ENTER" игра продолжается

Console.ReadLine();


Console.WriteLine("Отлично, давай начнем!!! Я буду загадывать число от 1 до 5, а ты отгадывай. Есть одно НО, у тебя три попытки. Поехали :)");

int user_Point = 3;
int game_Point = 0;
int Count = 0;

while (user_Point > 0)
{
    Console.WriteLine("");  // Число игрока
    int numA = int.Parse(Console.ReadLine()); 
    Random rnd = new Random();   // Загаданное число Алешкой
    int numB = rnd.Next(1 , 6);
    Console.WriteLine("Твое число: " + numA);
    
    if (numA == numB)
    {
        Console.WriteLine("Поздравляю, я загадал число: " + numB);
        break;
    }
    else
    {
        Console.WriteLine("Не угадал, попробуй еще раз");
        user_Point --;  // После каждой неудачной покупки минус одна попытка
        continue;
    }

}

Console.WriteLine("Очень жаль, твои попытки закончились :((");
