// See https://aka.ms/new-console-template for more information
int numberA = new Random().Next(1,10); // случайное число от 1 до 9
Console.Write ("Первое случайное число: ");
Console.WriteLine (numberA);
int numberB = new Random().Next(1,10);
Console.Write ("Второе случайное число: ");
Console.WriteLine (numberB);
int result = numberA+numberB;
Console.Write ("Общая сумма: ");
Console.WriteLine(result);
