Console.Write("Введите ваше имя: ");
string username = Console.ReadLine();

if(username.ToLower() == "стас")
{
    Console.WriteLine("Привет, создатель!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}