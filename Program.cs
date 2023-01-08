while (true)
{
    Console.WriteLine($"Witaj w zgadnij liczbe, liczba jest mniejsza niż tysiąc i większa od zera. \r\n Wpisz liczbe prób: ");
    Random random = new Random();
    int num = random.Next(1000);
    string probInput = Console.ReadLine();
    if (!int.TryParse(probInput, out int liczbaProb))
    {
        Console.WriteLine("Podaj poprawną liczbę: ");
    }

    for (int i = 0; i < liczbaProb; i++)
    {
        {
            Console.WriteLine("Zgadnij liczbe (do 1000): ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int inputNum))
            {
                Console.WriteLine("To nie liczba!");
            }

            if (inputNum < num)
            {
                Console.WriteLine("Za mało!");
            }
            if (inputNum > num)
            {
                Console.WriteLine("Za dużo!");
            }
            if (inputNum == num)
            {
                Console.WriteLine("Zgadłeś! Zagrać jeszcze raz? (T/N)");
                while (true)
                {
                    string zagrac = Console.ReadLine();
                    zagrac = zagrac.ToUpper();
                    if (zagrac != "T" && zagrac != "N")
                    {
                        Console.WriteLine("Niepoprawny znak. Zagrać jeszcze raz? (T/N)");
                    }
                    if (zagrac == "N")
                    {
                        Environment.Exit(0);
                    }
                    if (zagrac == "T")
                    {
                        break;
                    }
                }
                break;
            }
        }
    }
}

