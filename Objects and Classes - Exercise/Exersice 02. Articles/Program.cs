using System;

namespace Exersice_02._Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] currArticle = Console.ReadLine().Split(", ");
            var article = new Article(currArticle[0], currArticle[1], currArticle[2]);

            int countOfChanges = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfChanges; i++)
            {
                string[] lines = Console.ReadLine().Split(": ");
                string command = lines[0];
                string argument = lines[1];

                if (command== "Edit")
                {
                    article.Edit(argument);
                    
                       
                }
                else if (command== "ChangeAuthor")
                {
                    article.ChangeAuthor(argument);
                }
                else if (command == "Rename")
                {
                    article.Rename(argument);
                }
            }
            Console.WriteLine(article);
        }
    }


    class Article
    {
        public Article(string title, string content, string author)
        {

            Title = title;
            Content = content;
            Author = author;
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
    public void Edit (string content) => Content = content;
        public void ChangeAuthor(string author) => Author = author;

        public void Rename(string title) => Title = title;
        public override string ToString() => $"{Title} - {Content}: {Author}";
        }

    }
   



