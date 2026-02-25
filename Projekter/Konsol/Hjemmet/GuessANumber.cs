namespace Hjemmet
{
    public class GuessANumber
    {
        public void Start()
        {
            Console.WriteLine("Gæt et tal er ikke implementeret endnu.");
            
            Random random = new Random();
            int randomNumber = random.Next(101);
            Console.WriteLine(randomNumber);

		}
    }
}
