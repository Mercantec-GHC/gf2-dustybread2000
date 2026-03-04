using System;
using System.Collections.Generic;

namespace Opgaver
{
    public class Methods
    {
        public static void Run()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Velkommen til opgaver omkring Methods, Params, Return og Recursion!");
            
            // Grundlæggende methods
            Method1();
            Method2();
            Method3();
            
            // Parameter opgaver
            Parameter1();
            Parameter2();
            Parameter3();
            Parameter4();
            
            // Return value opgaver
            Return1();
            Return2();
            Return3();
            Return4();
            
            // Recursion opgaver
            Recursion1();
            Recursion2();
            
            // Mini-projekter
            MiniProjektLommeregner();
            MiniProjektTalSpil();
        }

        public static void Method1()
        {
            Console.WriteLine("Opgave 1 (Grundlæggende method):");
            Console.WriteLine("Lav en method der udskriver 'Hej verden!' og kald den fra denne method.");
            // Lav opgaven herunder!

            SkrivHejVärden();
			//Anropar metoden 'SkrivHejVärden' nedanför 
			//'Method1' körs hoppar det ner till metoden nedan 
            //'SkrivHejVärden' och kör koden där
		}

		public static void SkrivHejVärden()
			//Egen metod som skriver ut "Hej världen!" när den anropas
        {
            Console.WriteLine("Hej världen!");
			//Koden som skriver ut "Hej världen!" på konsolen
		}

		public static void Method2()
        {
            Console.WriteLine("Opgave 2 (Grundlæggende method):");
            Console.WriteLine("Lav en method der udskriver tallene fra 1 til 5 og kald den fra denne method.");
            // Lav opgaven herunder!
            Ketchupp();
		}

        public static void Ketchupp()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
			}
		}
        

        public static void Method3()
        {
            Console.WriteLine("Opgave 3 (Grundlæggende method):");
            Console.WriteLine("Lav en method der beder brugeren om deres navn og hilser på dem, og kald den fra denne method.");
            // Lav opgaven herunder!
            HilsePåBrugeren();  
		}
        public static void HilsePåBrugeren()
        {
            Console.WriteLine("Hvad er dit navn?");
            string navn = Console.ReadLine();
            Console.WriteLine($"Hej {navn}!");
		}

		public static void Parameter1()
        {
            Console.WriteLine("Opgave 4 (Parameter):");
            Console.WriteLine("Lav en method der tager et navn som parameter og udskriver 'Hej [navn]!'");
            // Lav opgaven herunder!
            // Kald metoden med dit eget navn
            nameParameter("Nicole");
            nameParameter("Nicole", 25, 1999, "Black");
            nameParameter("Nicole", 25, 1999, "Black");
            nameParameter("Nicole", 25, 1999, "Black");
            nameParameter("Nicole", 25, 1999, "Black");
            nameParameter("Nicole", 25, 1999, "Black");
            nameParameter("Nicole", 25, 1999, "Black");
            nameParameter("Nicole", 25, 1999, "Black");
            Console.WriteLine("Hej nicole, du er 25 aar gammel og er fra 1999 og har sort undertoej på!");
            Console.WriteLine("Hej nicole, du er 25 aar gammel og er fra 1999 og har sort undertoej på!");
            Console.WriteLine("Hej nicole, du er 25 aar gammel og er fra 1999 og har sort undertoej på!");
            Console.WriteLine("Hej nicole, du er 25 aar gammel og er fra 1999 og har sort undertoej på!");
            Console.WriteLine("Hej nicole, du er 25 aar gammel og er fra 1999 og har sort undertoej på!");
            Console.WriteLine("Hej nicole, du er 25 aar gammel og er fra 1999 og har sort undertoej på!");
		}

        public static void nameParameter(string name, int age, int year, string underwearColor)
        {
            Console.WriteLine($"Hej {name}");
            Console.WriteLine($"Hej {name}, du er {age} år gammel, og er fra {year}, og har {underwearColor} undertoej på!");
			// Denna metod tar fyra parametrar: 'name' (string), 'age' (int), 'year' (int) och 'underwearColor' (string).
			// Den skriver ut en hälsning som inkluderar alla dessa parametrar i en formaterad sträng.
            // Ändrar underkläder till tröja eller vad som
		}

		public static void Parameter2()
        {
            Console.WriteLine("Opgave 5 (Parameter):");
            Console.WriteLine("Lav en method der tager to tal som parametre og udskriver summen af dem.");
            // Lav opgaven herunder!
            // Kald metoden med to forskellige tal
        }

        public static void Parameter3()
        {
            Console.WriteLine("Opgave 6 (Parameter):");
            Console.WriteLine("Lav en method der tager et tal som parameter og tjekker om det er lige eller ulige.");
            // Lav opgaven herunder!
            // Kald metoden med både et lige og et ulige tal
        }

        public static void Parameter4()
        {
            Console.WriteLine("Opgave 7 (Flere parametre):");
            Console.WriteLine("Lav en method der tager navn, alder og by som parametre og udskriver en præsentation.");
            // Lav opgaven herunder!
            // Eksempel: "Jeg hedder [navn], er [alder] år gammel og kommer fra [by]"
        }

        public static void Return1()
        {
            Console.WriteLine("Opgave 8 (Return value):");
            Console.WriteLine("Lav en method der tager to tal som parametre og returnerer summen. Udskriv resultatet.");
            // Lav opgaven herunder!
        }

        public static void Return2()
        {
            Console.WriteLine("Opgave 9 (Return value):");
            Console.WriteLine("Lav en method der tager et tal som parameter og returnerer om det er lige (true/false).");
            // Lav opgaven herunder!
        }

        public static void Return3()
        {
            Console.WriteLine("Opgave 10 (Return value):");
            Console.WriteLine("Lav en method der tager et navn som parameter og returnerer 'Hej [navn]!'");
            // Lav opgaven herunder!
        }

        public static void Return4()
        {
            Console.WriteLine("Opgave 11 (Return value):");
            Console.WriteLine("Lav en method der tager tre tal som parametre og returnerer det største tal.");
            // Lav opgaven herunder!
        }

        public static void Recursion1()
        {
            Console.WriteLine("Opgave 12 (Recursion):");
            Console.WriteLine("Lav en rekursiv method der beregner fakultet af et tal (f.eks. 5! = 5*4*3*2*1).");
            Console.WriteLine("Tip: Fakultet af n = n * fakultet af (n-1), og fakultet af 1 = 1");
            // Lav opgaven herunder!
        }

        public static void Recursion2()
        {
            Console.WriteLine("Opgave 13 (Recursion):");
            Console.WriteLine("Lav en rekursiv method der tæller ned fra et givet tal til 0.");
            Console.WriteLine("Eksempel: CountDown(3) skal udskrive: 3, 2, 1, 0");
            // Lav opgaven herunder!
        }

        public static void MiniProjektLommeregner()
        {
            Console.WriteLine("\nMini-projekt: Lommeregner med methods (skabelon)");
            Console.WriteLine("Opgave:");
            Console.WriteLine("Lav et program med separate methods for de fire regnearter (+, -, *, /).");
            Console.WriteLine("Hver method skal tage to tal som parametre og returnere resultatet.");
            Console.WriteLine("Lav en hovedmethod der beder brugeren om to tal og en operation, og kalder den rigtige method.");
            // Lav opgaven herunder!
        }

        public static void MiniProjektTalSpil()
        {
            Console.WriteLine("\nMini-projekt: Gæt-et-tal spil med methods (skabelon)");
            Console.WriteLine("Opgave:");
            Console.WriteLine("Lav et gæt-et-tal spil ved brug af methods:");
            Console.WriteLine("- En method til at generere et tilfældigt tal");
            Console.WriteLine("- En method til at få brugerens gæt");
            Console.WriteLine("- En method til at sammenligne gæt med det rigtige tal");
            Console.WriteLine("- En method til at give feedback ('for højt', 'for lavt', 'rigtigt!')");
            // Lav opgaven herunder!
        }
    }
}