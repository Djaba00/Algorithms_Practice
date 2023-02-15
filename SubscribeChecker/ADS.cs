using System;
namespace SubscribeChecker
{
    public class ADS
    {
        public static void ShowAds(int num)
        {
            switch(num)
            {
                case 1:
                    Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
                    // Остановка на 1 с
                    Thread.Sleep(1000);
                    break;
                case 2:
                    Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
                    // Остановка на 2 с
                    Thread.Sleep(2000);
                    break;
                case 3:
                    Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
                    // Остановка на 3 с
                    Thread.Sleep(3000);
                    break;
            }
        }
    }
}

