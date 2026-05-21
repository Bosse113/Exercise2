namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool meny = true;

            while (meny == true)
            {
                // MENY
                Console.WriteLine("--- Huvudmeny ---");
                Console.WriteLine("1. Ålderskategori");
                Console.WriteLine("2. Totalpris för sällskapet");
                Console.WriteLine("0. Avsluta");
                Console.Write("Välj: ");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        CheckAge();
                        break;
                    case "2":
                        groupOfPeople();
                        break;
                    case "0":
                        meny = false;
                        break;

                    default:
                        Console.WriteLine("Felaktig inmatning");
                        break;
                }

            }
        }

        private static void groupOfPeople()
        {
            int totalPris = 0; //startvärde på totalpriset
            Console.Write("Hur många personer?");
            int numberOfGuests = int.Parse(Console.ReadLine());
            Console.WriteLine("För skriv in ålder för varje person:");
            for (int i = 0; i < numberOfGuests - 1; i++)
            {
                Console.Write($"Ålder på person {i+1} :");
                int guestAge = int.Parse(Console.ReadLine());
                if (guestAge < 20) 
                {
                    totalPris += 80;
                }
                else if (guestAge >64)
                {
                    totalPris += 90;
                }
                else
                {
                    totalPris += 120;
                }
            }
            Console.WriteLine($"Antal personer: {numberOfGuests} totalpris : {totalPris} ");
         }

        private static void CheckAge()
        {
            //Kolla om ungdom <20 (80kr) eller pensionär >64 (90kr) annars 120 kr
            Console.Write("Skriv in åldern på personen:");
            int age = int.Parse(Console.ReadLine());
            if (age < 20)
            {
                Console.WriteLine("Ungdomspris:80 kr.");
            }
            else if (age > 64)
            {
                Console.WriteLine("Pensionärspris:90 kr.");
            }
            else
            {
                Console.WriteLine("Standardpris:120 kr.");
            }
        }
    }
    
}
