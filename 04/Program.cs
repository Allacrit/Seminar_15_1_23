Console.Clear();

Console.WriteLine("Найти расстояние между точками в пространстве 2D/3D.");
Console.Write("Введите количество осей (минимум - 1, максимум - 3): ");
int numberAxes = NumbersAxes(int.Parse(Console.ReadLine()));

Console.Write("Введите размер пространства (минииум - 10, максимум - 200: ");
int maxValue = MaxValues(int.Parse(Console.ReadLine()));
int minValue = -maxValue;

int[] PointA = PointCoords(numberAxes);
int[] PointB = PointCoords(numberAxes);

Console.WriteLine("Система генерирует координаты точек А и В");

Console.Write($"Координаты точки А: ");
PrintCoords(PointA);
Console.Write($"Координаты точки B: ");
PrintCoords(PointB);

Console.WriteLine($"Расстояние между точками А и В: {Distance(PointA, PointB)}");

int MaxValues(int val)
{
    if (val < 10)
    {
        Console.WriteLine("Введен размер менее 10!! ПРИСВОЕН МИНИМАЛЬНЫЙ РАЗМЕР!");
        return 10 / 2;
    }
    else if (val > 200)
    {
        Console.WriteLine("Введен размер более 200!! ПРИСВОЕН МАКСИМАЛЬНЫЙ РАЗМЕР!");
        return 200 / 2;
    }
    else
    {
        Console.WriteLine($"Введен размер {val}.");
        return val / 2;
    }
}

int NumbersAxes(int axes)
{
    switch (axes)
    {
        case 0:
            {
                Console.WriteLine("Введенно число осей 0, такое кол-во осей НЕДОПУСТИМО. Выбрано минимальное кол-во осей - 1.");
                return 1;
                break;
            }
        case 1:
            {
                Console.WriteLine("Выбранно кол-во осей - 1.");
                return axes;
                break;
            }
        case 2:
            {
                Console.WriteLine("Выбранно кол-во осей - 2.");
                return axes;
                break;
            }
        case 3:
            {
                Console.WriteLine("Выбранно кол-во осей - 3.");
                return axes;
                break;
            }
        default:
            {
                Console.WriteLine($"Введенно число осей {axes}, такое кол-во осей НЕДОПУСТИМО. Выбрано максимальное кол-во осей - 3.");
                return 3;
                break;
            }
    }
}

int[] PointCoords(int numberAxes)
{
    int[] coords = new int[numberAxes];
    for (int i = 0; i < numberAxes; i++)
    {
        coords[i] = new Random().Next(minValue, maxValue);
    }
    return coords;
}

void PrintCoords(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        switch (i)
        {
            case 0: Console.Write($" x = {array[i]}; "); break;
            case 1: Console.Write($" y = {array[i]}; "); break;
            case 2: Console.Write($" z = {array[i]}; "); break;
        }
    }
    Console.WriteLine();
}

double Distance(int[] arr1, int[] arr2)
{
    int sum = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        sum = sum + (arr1[i] - arr2[i]) * (arr1[i] - arr2[i]);
    }
    double result = Math.Sqrt(sum);
    return result;
}

