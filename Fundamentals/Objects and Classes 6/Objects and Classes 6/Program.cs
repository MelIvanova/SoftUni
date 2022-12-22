using System;

namespace Objects_and_Classes_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phrase =
          {"Excellent product.", "Such a great product.",
            "I always use that product.", "Best product of its category.",
            "Exceptional product.", "I can’t live without this product."};

            string[] events = { "Now I feel good.", "I have succeeded with this product.",
            "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.",
            "Try it yourself, I am very satisfied.", "I feel great!"};

            string[] author = {"Diana", "Petya", "Stella", "Elena",
            "Katya", "Iva", "Annie", "Eva"};

            string[] city = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            Random shift = new Random();

            int numberOfMaseges = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfMaseges; i++)
            {
                int phraseIndex = shift.Next(0, phrase.Length);
                string currPhrase = phrase[phraseIndex];
                int eventsIndex = shift.Next(0, events.Length);
                string currEvent = events[eventsIndex];
                int autorIndex = shift.Next(0, author.Length);
                string currAutor = author[autorIndex];
                int cityIndex = shift.Next(0, city.Length);
                string currCity = city[cityIndex];

                Console.WriteLine($"{currPhrase} {currEvent} {currAutor} – {currCity}.");
            }
        }
    }
}
