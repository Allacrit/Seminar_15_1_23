Console.Clear();
Console.WriteLine("Дано число, обозначающее день недели. Выяснить, является номер дня недели выходным.");
Console.Write("Введите число обозначающее день недели: ");
int dayNumber = int.Parse(Console.ReadLine());
string [] Week = { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье" };
string txtResult = "";

if(dayNumber < 8 && dayNumber > 0)
{
    if (dayNumber > 5) 
    {
        txtResult = $". Ура! Это выходной день!";
    }
    else
    {
        txtResult = $", будний день.";
    } 
    Console.WriteLine($"{dayNumber}-й день недели - это {Week [dayNumber - 1]}{txtResult}");
}
else
{
    Console.WriteLine($"Число {dayNumber} не входит в формат длинны недели!");
}

