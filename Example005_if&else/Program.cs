// See https://aka.ms/new-console-template for more information

Console.WriteLine("Введите имя пользователя!");

string username = Console.ReadLine();

if (username.ToLower() == "masha")
  {
    Console.WriteLine("Ura, Masha prishla!");
  }
  else
  {
    Console.WriteLine("Privet, ");
    Console.WriteLine("ti ne Masha!");
  }
