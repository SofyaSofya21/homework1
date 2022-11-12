// Программа, которая на вход принимает число N, а на выходе показывает все четные числа от 1 до N

Console.WriteLine("Введите число больше 1");
int number = 0;
int count = 0;
int limit = 1;

// Проверка, не равно ли число единице

bool isCorrect = false;
while(!isCorrect)
{
    number = Convert.ToInt32(Console.ReadLine());
    if(number == limit)
    {
        Console.WriteLine("Вы ввели 1, введите другое число");
    }
    else
    {
        isCorrect = true;
    }
}

//Основная часть программы
if(number > limit)
{
    count = 2; //первое четное число после 1
    Console.Write($"Вывод всех четных чисел от 1 до {number} включительно -> ");
    while(count<(number-1)) // чтобы при выводе не было запятой после последнего числа :)
    {
        Console.Write($"{count}, ");
        count += 2;
    }
    if(number%2==0) // Вывод последнего четного числа без запятой
    {
        Console.Write(number);
    }
    else
    {
        Console.Write(number-1);
    }
}
else
{
    if(number%2 == 0)
    {
        count = number;
    }
    else
    {
        count = number + 1;
    }
    Console.Write($"Хотя вы ввели значение меньше 1, посмотрите все четные числа от {number} до 1 -> ");
    while(count<0)
    {
        Console.Write($"{count}, ");
        count += 2;
    }
    Console.Write("0"); // чтобы 0 как последнее четное число перед 1 был без запятой при выводе
}