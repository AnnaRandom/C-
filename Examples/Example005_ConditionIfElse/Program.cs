
Console.WriteLine("Введите ваше имя");
string username = Console.ReadLine();
if ( username.ToLower () == "маша")
{
    Console.WriteLine ("Маша, ты дура!");
}
else 
{
    Console.WriteLine ("Привет, ");
    Console.Write (username);
}