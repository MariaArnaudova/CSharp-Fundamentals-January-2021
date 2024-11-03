using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Articles2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int articlesNumbers = int.Parse(Console.ReadLine());

            List<Article> newArticleList = new List<Article>();

            for (int i = 0; i < articlesNumbers; i++)
            {
                string[] typeArct = Console.ReadLine().Split(", ");

                string title = typeArct[0];
                string content = typeArct[1];
                string autor = typeArct[2];

                Article currentArticle = new Article(title, content, autor);

                newArticleList.Add(currentArticle);
            }

            string typeProperties = Console.ReadLine();
            if (typeProperties == "title")
            {
                foreach (Article item in newArticleList.OrderBy(currenArticle => currenArticle.Title))
                {
                    Console.WriteLine($"{item.Title} - {item.Content}: {item.Autor}");
                }
            }
            else if (typeProperties == "content")
            {
                foreach (Article item in newArticleList.OrderBy(currenArticle => currenArticle.Content))
                {
                    Console.WriteLine($"{item.Title} - {item.Content}: {item.Autor}");
                }
            }
            else if (typeProperties == "author")
            {
                foreach (Article item in newArticleList.OrderBy(currenArticle => currenArticle.Autor))
                {
                    Console.WriteLine($"{item.Title} - {item.Content}: {item.Autor}");
                }
            }         
        }
    }

    class Article
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public string Autor { get; set; }

        public Article(string title, string content, string autor)
        {
            this.Title = title;
            this.Content = content;
            this.Autor = autor;
        }
        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Autor}";
        }
    }
}
