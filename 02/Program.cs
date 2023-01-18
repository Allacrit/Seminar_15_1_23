Console.Clear(); 
Console.WriteLine("По двум заданным числам проверять является ли первое квадратом второго.");
Console.Write("Введите число в котором проверяем значание: ");
string writeNumber1 = Console.ReadLine();
int number1 = int.Parse(writeNumber1);

Console.Write("Введите число которое является квадратом первого числа: ");
string writeNumber2 = Console.ReadLine();
int number2 = int.Parse(writeNumber2);

string txtResult = $"Число {number1} не является квадратом числа {number2}";

if (number1 == number2 * number2)
{
    txtResult = txtResult.Replace(" не", "");
}
Console.WriteLine(txtResult);