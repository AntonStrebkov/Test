Console.WriteLine("Введите Ваше имя ");
string username = Console.ReadLine();

if(username.ToLower() == "ксюша")
{
    Console.WriteLine("УРА! Это же Ксюша!");
}

else
{
    Console.WriteLine("Здравствуйте, ");
    Console.WriteLine(username);
}