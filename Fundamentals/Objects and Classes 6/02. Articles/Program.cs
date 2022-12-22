using System;

namespace _02._Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] income = Console.ReadLine().Split(", ");
            int num = int.Parse(Console.ReadLine());
            Article article = new Article(income[0], income[1], income[2]);

            for (int i = 0; i < num; i++)
            {
                string[] tokens = Console.ReadLine().Split(": ");
                string command = tokens[0];
                string contens = tokens[1];

                switch (command)
                {
                    case "Edit":
                        article.Edit(contens);
                        break;
                    case "ChangeAuthor":
                        article.ChangeAutor(contens);
                        break;
                    case "Rename":
                        article.Rename(contens);
                        break;
                }
            }

            Console.WriteLine(article.ToString());
        }
    }

    class Article 
    { 
        public Article(string title, string content, string autor)
        {
            Title = title;
            Content = content;
            Autor = autor;
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Autor { get; set; }

        public void Edit(string content)
        {
            Content = content;
        }

        public void ChangeAutor(string autor)
        {
            Autor = autor;
        }

        public void Rename(string title)
        {
            Title = title;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Autor}";
        }

    }
}
