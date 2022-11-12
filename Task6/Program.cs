// Программа, которая на вход принимает число и сообщает, является ли оно четным

Console.WriteLine("Введите любое число");
int number = Convert.ToInt32(Console.ReadLine());

int even = number%2;

if(even == 0)
{
    Console.WriteLine($"Число {number} является четным");
}
else
{
    Console.WriteLine($"Число {number} НЕ является четным");
}