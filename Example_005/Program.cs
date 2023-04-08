Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "евгений")
{
    Console.WriteLine("Ура, привет");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}