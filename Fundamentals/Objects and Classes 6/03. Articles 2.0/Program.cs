using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Articles_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();
            

            for (int i = 0; i < numb; i++)
            {
                string[] containce = Console.ReadLine().Split(", ");
                Article current = new Article();
                current.Title = containce[0];
                current.Content = containce[1];
                current.Autor = containce[2];
                articles.Add(current);
            }
            string criteria = Console.ReadLine();
            if (criteria== "title")
            {
                articles = articles.OrderBy(X => X.Title).ToList();
            }
            else if (criteria == "content")
            {
                articles = articles.OrderBy(X => X.Content).ToList();
            }
            else if (criteria == "autor")
            {
                articles = articles.OrderBy(X => X.Autor).ToList();
            }

            Console.WriteLine(string.Join(Environment.NewLine, articles));
        }
    }

    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Autor { get; set; }
        public override string ToString()
        {
            return $"{Title} - {Content}: {Autor}";
        }
    }
}
