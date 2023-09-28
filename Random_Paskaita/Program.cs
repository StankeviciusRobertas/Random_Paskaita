namespace Random_Paskaita
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Random rand = new Random(1);

            //int randomNumber = rand.Next(1, 101);
            //Console.WriteLine($"Atsitiktinis skaicius yra: {randomNumber}");

            //////////////////////////////////////////////////////////////////
            //GetRandomNumber();
            //////////////////////////////////////////////////////////////////

            //Console.WriteLine(RandomBool());
            /////////////////////////////////////////////////////////////////

            //RandomLetter();
            //////////////////////////////////////////////////////////////////

            //Random random = new Random();
            //RandomSum();
            /////////////////////////////////////////////////////////////////

            int randomNumber = RandomNumber();

            Console.WriteLine("Spekite ar sugeneruotas skaicius yra desnis nei 50 y/n");
            string userInput = Console.ReadLine();

            if (userInput == "y" && randomNumber > 50)
            {
                Console.WriteLine($"Atspejote, skaicius yra didesnis nei 50, sugeneruotas skaicius {randomNumber}");
            }
            else if (userInput == "n" && randomNumber < 50)
            {
                Console.WriteLine($"Atspejote, skaicius yra mazesnis nei 50, sugeneruotas skaicius {randomNumber}");
            }
            else
            {
                Console.WriteLine($"Neatspejote");
            }

        }
        public static int RandomNumber()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 100);

            for (int i = 0; i < 10; i++)
            {
                randomNumber = random.Next(1, 101);                
            }
            return randomNumber;
        }
        public static void RandomSum()
        {
            Random random = new Random();
            int sum = 0;

            for (int i = 0; i < 100; i++)
            {
                int b = random.Next(0, 7);
                int c = random.Next(0, 7);
                sum = b + c;
                Console.WriteLine($"{b} + {c} = {sum}");
            }

        }
        public static void RandomLetter()
        {
            Random random = new Random();
            for (int i = 0; i < 1; i++)
            {
                int a = random.Next(65, 90);
                Console.WriteLine((char)a);
            }
        }
        public static bool RandomBool()
        {
            Random random = new Random();
            int random1 = random.Next(0, 2);

            return random1 == 1;
        }
        public static void GetRandomNumber()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 100);

            for (int i = 0; i < 10; i++)
            {
                randomNumber = random.Next(1, 101);
                Console.WriteLine($"Random skaiciai: {randomNumber}");
            }
        }
    }
}