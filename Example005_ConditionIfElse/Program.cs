﻿Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("Ура, эта же МАША!!!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}