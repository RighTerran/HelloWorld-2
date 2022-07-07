// See https://aka.ms/new-console-template for more information
Console.Write("Введите Ваше имя: ");
String username = Console.ReadLine();
if (username.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же маша!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
    
