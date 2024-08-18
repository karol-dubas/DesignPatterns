using System;

namespace Singleton
{
    class Program
    {
        // Singleton ogranicza możliwość tworzenia ilości obiektów klasy do 1 instancji
        // oraz zapewnia globalny dostep do tego obiektu.

        // Często jest nadużywany lub źle implementowany, przez co jest nazywany antywzorcem, bo:
        // 1. Utrudnia pisanie testów jednostkowych, można jednak czyscić singleton przed
        //    każdym wykonaniem testu.
        // 2. Sprawia, że kod staje się bardziej powiązany.
        // 3. Łamie SRP, bo od startu inicjalizuje instancje oraz pełni funkcje biznesowe.
        // 4. Łamie OCP, ponieważ do poszerzenia jego funkcjonalności trzeba zmnieniać jego kod.

        // Chcę mieć dostęp do pliku konfiguracyjnego we wszystkich klasach projektu.

        static void Main(string[] args)
        {
            var cfg1 = Configuration.GetInstance();
            cfg1.TextSize = 12;

            // Ten obiekt również będzie miał te same dane, co cfg1.
            var cfg2 = Configuration.GetInstance();
            Console.WriteLine(cfg2.TextSize); // 12

            // Bo są to te same obiekty
            if (ReferenceEquals(cfg1, cfg2))
            {
                Console.WriteLine("Configuration is a singleton");
            }
        }
    }
}
