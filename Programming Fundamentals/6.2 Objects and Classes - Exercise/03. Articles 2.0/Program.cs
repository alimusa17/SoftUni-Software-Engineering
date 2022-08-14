using System;
using System.Collections.Generic;

namespace _03._Articles_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfArticles = int.Parse(Console.ReadLine());

            List<Article> articles = new List<Article>();

            for (int i = 0; i < countOfArticles; i++)
            {
                string[] curentArticle = Console.ReadLine().Split(", ");
                var article = new Article(curentArticle[0], curentArticle[1], curentArticle[2]);
                articles.Add(article);
            }

            string line = Console.ReadLine();

            foreach (var article in articles)
            {
                Console.WriteLine(article);
            }
        }
    }

    class Article
    {
        public Article(string title, string content, string author)
        {
            Author = author;
            Title = title;
            Content = content;
        }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public override string ToString() => $"{Title} - {Content}: {Author}";

    }
}

