Console.Clear();
Console.WriteLine("Задать номер четверти, показать диапазоны для возможных координат.");
Console.Write("Введите номер четверти: ");
int quarterNumber = int.Parse(Console.ReadLine());

switch(quarterNumber)
{
    case 1: Console.WriteLine("Для 1-й четверти координаты точки должны быть заданы в диапазоне (x > 0, y > 0)."); break;
    case 2: Console.WriteLine("Для 2-й четверти координаты точки должны быть заданы в диапазоне (x < 0, y > 0)."); break;
    case 3: Console.WriteLine("Для 3-й четверти координаты точки должны быть заданы в диапазоне (x < 0, y < 0)."); break;
    case 4: Console.WriteLine("Для 4-й четверти координаты точки должны быть заданы в диапазоне (x > 0, y < 0)."); break;
    default: Console.WriteLine($"Число {quarterNumber} не подходит для номера четверти!"); break;
}