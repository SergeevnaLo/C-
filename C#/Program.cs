// Задание 2. 

Console.WriteLine("Введите два числа: ");
int num1 = int.Parse(Console.ReadLine());  // вводим первое число
int num2 =  int.Parse(Console.ReadLine()); // вводим второе число

// вычисляем большее значение и передаем результат в зависимости от выполнения условия
if (num1 > num2)
{
    Console.WriteLine("Большее число: " + num1 + ", меньшее число:" + num2); 
}
else
{
    Console.WriteLine("Большее число: " + num2 + ", меньшее число:" + num1);
}
Console.ReadLine();

// Задание 4.

Console.WriteLine("Введите три числа: ");

int a = int.Parse(Console.ReadLine());  // вводим первое число
int b = int.Parse(Console.ReadLine());  // вводим второе число
int c = int.Parse(Console.ReadLine());  // вводим третье число

// вычисление большего значения из трех чисел
if (a > b)
{
    if (a > c)
    {
        Console.WriteLine("Большее число: " + a);
    }
    else 
    {
        Console.WriteLine("Большее число: " + c);
    }
}
else
{
     if (b > c)
    {
        Console.WriteLine("Большее число: " + b);
    }
    else
    {
        Console.WriteLine("Большее число: " + c);
    }
}
Console.ReadLine();

// Задание 6

Console.WriteLine("Введите число: ");
int s = int.Parse(Console.ReadLine());

// Вычисление четности чисел с помощью деления на 2
if ((s % 2) == 0)
{
    Console.WriteLine("Четное число");
}
else
{
    Console.WriteLine("Нечетное число");
}
Console.ReadLine();

// Задание 8

Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());

// Вычисление четности чисел с помощью цикла
for (int i = 1; i <= n; i++)
{
    if((i % 2) == 0) 
    { 
        Console.WriteLine(i + " "); 
    }
}

