using System;

namespace Opgaver
{
    public class ControlFlow
    {
        public static void Run()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine(
                @"Velkommen til opgaver omkring Control Flow med if, else if og else, 
            Switch og Ternary operator!"
            );
            If1();
            If2();

            Switch1();
            Ternary1();

            MiniProjektQuiz();
            MiniProjektKarakterFeedback();
        }

        public static void If1()
        {
            Console.WriteLine("Lav et program som tjekker om en given værdi er højere eller lavere end 18" +
                "Make a program that checks if a given value is higher or lower than 18"
			);
            // Lav opgaven herunder!
            Console.WriteLine("What number between 1-10 am I thinking of? ");
            string input = Console.ReadLine();
            int number = int.Parse(input);
            {
                if (number > 4)
                {
                    Console.WriteLine("The correct number was lower");
                }
                else if (number < 4)
                {
                    Console.WriteLine("The correct number was higher");
                }
                else
                {
                    Console.WriteLine("Correct");
				}

			}
		}


		public static void If2()
        {
            Console.WriteLine("Lav et program som tjekker om en given værdi er lige eller ulige" +
				"Create a program that checks if a given value is even or odd.");
            // Lav opgaven herunder!
            Console.WriteLine("Enter a number: ");
            string input = Console.ReadLine();
            int number = int.Parse(input);
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine("The number is even");
                }
                else
                {
                    Console.WriteLine("The number is odd");
                }
			}
		}

        public static void Switch1()
        {
            Console.WriteLine("Lav et program som tjekker om en given værdi er lige eller ulige");
            // Lav opgaven herunder!
            Console.WriteLine("Enter a number");
            string input = Console.ReadLine();
            int number = int.Parse(input);
            switch (number % 2)
            {
                case 0:
                    Console.WriteLine("The number is even");
                    break;
                case 1:
                    Console.WriteLine("The number is odd");
                    break;
                
			}
		}

        public static void Ternary1()
        {
            Console.WriteLine("Lav et program som tjekker om en given værdi er lige eller ulige");
            // Lav opgaven herunder!
            Console.WriteLine("Enter a number");
            string input = Console.ReadLine();
            int number = int.Parse(input);
            string result = (number % 2 == 0) ? "The number is even" : "The number is odd";
            Console.WriteLine(result);
		}

        public static void MiniProjektQuiz()
        {
            Console.WriteLine("\nMini-projekt: Simpelt quiz-spil (skabelon)");
            Console.WriteLine("Opgave:");
            Console.WriteLine(
                "Lav et program, der stiller brugeren tre spørgsmål (du vælger selv spørgsmål og svar)."
            );
            Console.WriteLine("Brugeren skal indtaste sit svar til hvert spørgsmål.");
            Console.WriteLine(
                "Programmet skal tjekke, om svaret er rigtigt eller forkert, og til sidst udskrive, hvor mange rigtige brugeren fik."
            );
            Console.WriteLine(
                "Tip: Brug variabler til at gemme point og svar, og if/else til at tjekke svarene."
            );
            // Lav opgaven herunder!
            Console.WriteLine("3 questions, 3 lives");
            int lives = 3;
            Console.WriteLine("1) Whats the color of my socks?");
            string answer1 = Console.ReadLine();
            if (answer1.ToLower() == "black")
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Wrong!");
                lives--;
                Console.WriteLine($"You got {lives} lives left!");

            }
            Console.WriteLine("2) Whats the color of my shirt?");
            string answer2 = Console.ReadLine();
            if (answer2.ToLower() == "black")
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Wrong!");
                lives--;
                Console.WriteLine($"You got {lives} lives left!");

            }
            Console.WriteLine("3) Whats the color of my nails?");
            string answer3 = Console.ReadLine();
            if (answer3.ToLower() == "pink")
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Wrong!");
                lives--;
            }

            Console.WriteLine($"You got {lives} lives left!");
        }



		public static void MiniProjektKarakterFeedback()
        {
            Console.WriteLine("\nMini-projekt: Karakter-feedback (skabelon)");
            Console.WriteLine("Opgave:");
            Console.WriteLine(
                "Lav et program, hvor brugeren indtaster en karakter (fx 12, 10, 7, 4, 02, 00 eller -3)."
            );
            Console.WriteLine(
                @"Programmet skal give en passende feedback baseret på karakteren, 
            fx 'Super flot!', 'Godt klaret', 'Du kan gøre det bedre' osv."
            );
            Console.WriteLine("Brug if/else eller switch til at vælge feedbacken.");

            Console.WriteLine(
                @"Ekstra opgave: Lav så man indtaster flere karaktere 
            for en bruger og man regner gennemsnittet ud."
            );
            // Lav opgaven herunder!
            Console.WriteLine("Enter your grade (12, 10, 7, 4, 02, 00 or -3):");
            string input = Console.ReadLine();
            int grade = int.Parse(input);

            switch (grade)
            {
                
            }

        }
    }
}
