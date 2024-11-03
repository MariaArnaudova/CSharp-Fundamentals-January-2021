using System;

namespace _02.Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] articles = Console.ReadLine().Split(", ");

            string title = articles[0];
            string content = articles[1];
            string autor = articles[2];

            Article newArticle = new Article(title,content,autor);

            int numberCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberCommands; i++)
            {

                string[] currCommands = Console.ReadLine().Split(": ");

                string command = currCommands[0];
                //string changeValue = currCommands[1];

                if (command == "Edit")
                {
                    string newContent = currCommands[1];
                    newArticle.Edit(newContent);
                }

                else if (command == "ChangeAuthor")
                {
                    string newAutor = currCommands[1];
                    newArticle.ChangeAutor(newAutor);
                }
                else if(command == "Rename")
                {
                    string newTitle = currCommands[1];
                    newArticle.Rename(newTitle);
                }
            }
            Console.WriteLine(newArticle.ToString());

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
        public void Edit(string newContent)
        {
            this.Content = newContent;
        }

        public void ChangeAutor(string newAutor)
        {
            this.Autor = newAutor;
        }

        public void Rename(string newtitle)
        {
            this.Title = newtitle;
        }

        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Autor}";
        }
    }
}
