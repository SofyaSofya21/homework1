// Программа, которая на вход принимает 2 числа и выдает, какое число большее, а какое меньшее

Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

int max = number1;
int min = number2;

if(number1 == number2)
{
    Console.WriteLine("Вы ввели одинаковые числа");
}
else
{
    if(max < number2)
    {
        max = number2;
        min = number1;
    }
    Console.WriteLine($"Число {max} большее, число {min} меньшее");
}

