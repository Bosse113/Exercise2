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
                Console.WriteLine("0. Avsluta");
                Console.Write("Välj: ");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        CheckAge();
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
