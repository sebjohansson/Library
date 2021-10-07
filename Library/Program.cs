using System;
using System.Collections.Generic;
using System.Threading;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> libraryCollection = new List<Book>();
            libraryCollection.Add(new Textbook("New Book 1", "J. Doe", 150, "Coding", 1));
            libraryCollection.Add(new Kids("New Book 2", "K. Doe", 250, 1, false));
            libraryCollection.Add(new Fiction("New Book 3", "L. Doe", 350, "Thriller", 0));

            string menuChoice = "0";
            while (menuChoice != "4")
            {
                Console.WriteLine("Choose an alternative");
                Console.WriteLine("1. Textbooks");
                Console.WriteLine("2. Kids");
                Console.WriteLine("3. Fiction");
                Console.WriteLine("4. Exit");
                menuChoice = Console.ReadLine();
                Console.WriteLine();

                switch (menuChoice)
                {
                    case "1":
                        foreach (Textbook textbook in libraryCollection)
                        {
                            Console.WriteLine("Title:       " + textbook.Title);
                            Console.WriteLine("Author:      " + textbook.Author);
                            Console.WriteLine("Pages:       " + textbook.Pages);
                            Console.WriteLine("Subject:     " + textbook.Subject);
                            Console.WriteLine("Difficulty:  " + textbook.Difficulty);
                        }
                        break;

                    case "2":
                        foreach (Kids kids in libraryCollection)
                        {
                            Console.WriteLine("Title:          " + kids.Title);
                            Console.WriteLine("Author:         " + kids.Author);
                            Console.WriteLine("Pages:          " + kids.Pages);
                            Console.WriteLine("Child or teen:  " + kids.ChildOrTeen);
                            Console.WriteLine("Pictures:       " + kids.Pictures);
                        }
                        break;

                    case "3":
                        foreach (Fiction fiction in libraryCollection)
                        {
                            Console.WriteLine("Title:                 " + fiction.Title);
                            Console.WriteLine("Author:                " + fiction.Author);
                            Console.WriteLine("Pages:                 " + fiction.Pages);
                            Console.WriteLine("Genre:                 " + fiction.Genre);
                            Console.WriteLine("Romance or Anthology:  " + fiction.RomanceOrAnthology);
                        }
                        break;

                    case "4":
                        break;

                    default:
                        Console.WriteLine("No valid choice.");
                        break;
                }
            }
        }
    }
}
