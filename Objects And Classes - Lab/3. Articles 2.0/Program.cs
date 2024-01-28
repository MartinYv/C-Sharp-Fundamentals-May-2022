using System;
using System.Collections.Generic;

namespace Exersice_02._Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Article> ListOfarticles= new List<Article>();
            
          


            int countOfChanges = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfChanges; i++)
            {
            
                string[] currArticle = Console.ReadLine().Split(", ");

                Article articleee = new Article
                 {
                     Title = currArticle[0],
                     Content = currArticle[1],
                     Author = currArticle[2]

                 };
                ListOfarticles.Add(articleee);
            }
            foreach (Article articleee in ListOfarticles)
            {
                Console.WriteLine(articleee);
            }
        }
    }


    class Article
    {
     
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public override string ToString() => $"{Title} - {Content}: {Author}";
    }

}




