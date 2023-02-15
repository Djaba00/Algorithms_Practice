using System;
using System.Collections.Generic;

namespace SubscribeChecker
{
	public static class Authorization
	{
		public static void Entrance(List<User> user)
		{
            Console.Write("Авторизация\nВведите свой логин: ");
            string login = Console.ReadLine();

            int userIndex = user.FindIndex(x => x.Login.Contains(login));

            if(userIndex > -1)
            {
                if (user[userIndex].IsPremium == false)
                {
                    Random random = new Random();
                    ADS.ShowAds(random.Next(1, 3));
                    Console.WriteLine("\nЧто бы использовать ресурс без рекламы преобретите пакет 'Премиум'\n");
                }
                Console.WriteLine($"{user[userIndex].Name}, добро пожаловать на сайт!");
            }
            else
            {
                Console.WriteLine("Пользователь с указанным логином не найден!");
            }
        }

    }
}

