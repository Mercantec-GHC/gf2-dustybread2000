using System;

namespace Opgaver
{
    public class Loops
    {
        public static void Run()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Velkommen til opgaver omkring Loops både med og uden datastrukturer!");
            Loop1();
            Loop2();
            Loop3();
            Loop4();
            Loop5();
            Loop6();
            Loop7();
            Loop8();
            Loop9();
            Loop10();
            BankeBøf();
            MiniProjektLommeregner();
        }

        public static void Loop1()
        {
            Console.WriteLine("Opgave 1:");
            Console.WriteLine("Brug et loop til at udskrive tallene fra 1 til 10.");
            // Lav opgaven herunder!
            for (int i =1; i <=10; i++) // Start a for loop that initializes an integer variable 'i' to 1, checks if 'i' is less than or equal to 10, and increments 'i' by 1 in each iteration
			{
                Console.WriteLine(i); // Inside the loop, print the current value of 'i' to the console
			}
        }

        public static void Loop2()
        {
            Console.WriteLine("Opgave 2:");
            Console.WriteLine("Brug et loop og en if-betingelse til at udskrive alle lige tal fra 2 til 20.");
            // Lav opgaven herunder!
            for (int i =1; i <=20; i++) // Start a for loop that initializes an integer variable 'i' to 1, checks if 'i' is less than or equal to 20, and increments 'i' by 1 in each iteration
				if (i % 2 == 0) //  Inside the loop, use an if statement to check if 'i' is even by checking if the remainder of 'i' divided by 2 is equal to 0
				{
                    Console.WriteLine(i); // If the condition is true (i.e., 'i' is even), print the current value of 'i' to the console
				}

		}

        public static void Loop3()
        {
            Console.WriteLine("Opgave 3:");
            Console.WriteLine("Brug et loop til at lægge alle tal fra 1 til 100 sammen og udskriv resultatet.");
            // Lav opgaven herunder!
            int sum = 0; // Initialize an integer variable 'sum' to 0, which will be used to store the cumulative sum of the numbers from 1 to 100
			for (int i =1; i <=100; i++) // Start a for loop that initializes an integer variable 'i' to 1, checks if 'i' is less than or equal to 100, and increments 'i' by 1 in each iteration
			{
                sum += i; // Lägger till/plusar med en
			}

		}

        public static void Loop4()
        {
            Console.WriteLine("Opgave 4:");
            Console.WriteLine("Bed brugeren om at indtaste sit navn og et tal. Udskriv navnet det antal gange ved hjælp af et loop.");
            // Lav opgaven herunder!
            Console.WriteLine("Enter your name:");      // Prompt the user to enter their name
			string name = Console.ReadLine();           // Read the user's input and store it in a variable called 'name'

			Console.WriteLine("Enter a number:");       // Prompt the user to enter a number
			int number = int.Parse(Console.ReadLine()); // Read the user's input, convert it to an integer using int.Parse, and store it in a variable called 'number'

			for (int i = 0; i < number; i++)            // Use a for loop to iterate from 0 to 'number - 1'
			{
                Console.WriteLine(name);                // Inside the loop, print the user's name on each iteration
			}
		}

        public static void Loop5()
        {
            Console.WriteLine("Opgave 5:");
            Console.WriteLine("Bed brugeren om at indtaste et tal. Brug et loop til at udskrive alle tal fra det indtastede tal og ned til 1.");
            // Lav opgaven herunder!
            Console.WriteLine("Enter a number:");       // Prompt the user to enter a number
            int number = int.Parse(Console.ReadLine()); // Read the user's input, convert it to an integer using int.Parse, and store it in a variable called 'number'

            for (int i = number; i >= 1; i--)          // Use a for loop to iterate from 'number' down to 1, decrementing 'i' by 1 in each iteration
                {
                Console.WriteLine(i);                   // Inside the loop, print the current value of 'i' to the console
			}
		}

        public static void Loop6()
        {
            Console.WriteLine("Opgave 6:");
            Console.WriteLine(@"Brug et loop til at udskrive alle bogstaverne i dit navn (ét bogstav pr. linje). 
            Navnet skal være gemt i en string variabel.");
            // Lav opgaven herunder!
            string name = "Nicole"; // string variabel med ditt namn 
            for (int i = 0; i < name.Length; i++) // använd en for loop för att upprepa så många gånger som det finns i 'name', där 'name.Length' ger antalet tecken i stringen
			{
                Console.WriteLine(name[i]); //skriver ut varje tecken i 'name' på en ny rad, där 'name[i]' ger det tecken som finns på index 'i' i stringen
			} 
		}

        public static void Loop7()
        {
            Console.WriteLine("Opgave 7:");
            Console.WriteLine("Brug et loop til at tælle, hvor mange gange bogstavet 'a' optræder i en tekst, som brugeren indtaster.");
            // Lav opgaven herunder!
            Console.WriteLine("Enter a text:");       // ber användaren att skriva in en text
            string text = Console.ReadLine();        // läser in texten och sparar den i en variabel som heter 'text'
            int count = 0;                          // skapar en variabel 'count' som kommer att användas för att räkna antalet gånger bokstaven 'a' förekommer i texten
		}

        public static void Loop8()
        {
            Console.WriteLine("Opgave 8:");
            Console.WriteLine("Brug et loop til at udskrive alle ulige tal mellem 1 og 50.");
            // Lav opgaven herunder!
            for (int 1 = 1; i <= 50; int++) // startar en for loop som sätter igång ett heltal 'i' till 1, och fortsätter så länge 'i' är mindre än eller lika med 50, och ökar 'i' med 1 i varje iteration
                {
                if (i % 2 != 0) // inuti loopen, använder en if-sats för att kontrollera om 'i' är udda genom att kolla om resten av 'i' delat med 2 inte är lika med 0

		}

        public static void Loop9()
        {
            Console.WriteLine("Opgave 9:");
            Console.WriteLine("Bed brugeren om at indtaste 5 tal (ét ad gangen). Brug et loop til at lægge dem sammen og udskriv summen til sidst.");
            // Lav opgaven herunder!
        }

        public static void Loop10()
        {
            Console.WriteLine("Opgave 10:");
            Console.WriteLine("Lav et program, hvor brugeren skal gætte et hemmeligt tal mellem 1 og 10. Brug et loop, så brugeren kan gætte indtil det rigtige tal er fundet.");
            // Lav opgaven herunder!
            Random random = new Random(); // Skapar en instans av Random-klassen som kan användas för att generera slumpmässiga tal
            int secretNumber = random.Next(1, 11); // Genererar ett slumpmässigt tal mellan 1 och 10 (11 är exklusivt) och sparar det i variabeln 'secretNumber'
            Console.WriteLine(secretNumber); // Skriv ut det hemliga numret (för teständamål, i en riktig gissningslek skulle
            
		}

        public static void BankeBøf()
        {
            Console.WriteLine(@"Lav et program med et loop, som udskriver tallene fra 1 til 30. 
            Udskriv 'Banke' hvis tallet er deleligt med 3, 'Bøf' hvis tallet er deleligt med 5 
            og 'BankeBøf' hvis tallet er deleligt med både 3 og 5.");
            // Lav opgaven herunder!
        }
        public static void MiniProjektLommeregner()
        {
            Console.WriteLine("\nMini-projekt: Simpel lommeregner (skabelon)");
            Console.WriteLine("Opgave:");
            Console.WriteLine("Lav et program, hvor brugeren indtaster to tal og vælger en regneart (+, -, * eller /).");
            Console.WriteLine("Programmet skal udregne og udskrive resultatet.");
            Console.WriteLine("Tip: Brug if/else eller switch til at vælge regnearten.");
            // Lav opgaven herunder!
        }
    }
}