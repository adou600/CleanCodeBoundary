using AdapterExample_CleanCodeBoundaries.FileLogger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterExample_CleanCodeBoundaries
{
    class Program
    {
        

        static void Main(string[] args)
        {
            //TODO: get the right logger from config file (test vs prod)
            //IFileLogger logger = new FakeFileLogger();
            IFileLogger logger = new FileLoggerAdapter();
            logger.InitFile("blabla.txt");

            //Generate some books
            List<Book> books = new List<Book>
            {
                new Book { Title = "Clean Code, Refactoring, Patterns, Testen und Techniken für sauberen Code",
                           PageNumer = 345, 
                           KeyWords = new List<string> { "CleanCode", "Patterns", "Refactoring" } },
                new Book { Title = "Analyse und Design mit UML 2.1",
                           PageNumer = 465, 
                           KeyWords = new List<string> { "UML", "2.1" } }, 
                new Book { Title = "Moderne Webanwendungen mit ASP.NET MVC4", 
                           PageNumer = 364, 
                           KeyWords = new List<string> { "MVC4", "ASP.NET" } },
                new Book { Title = "Manning: ASP.NET MVC 4 in Action", 
                           PageNumer = 364, 
                           KeyWords = new List<string> { "MVC4", "ASP.NET" } }
            };

            new Program().FindMVCBooks(books, logger);
            Console.ReadLine();


        }

        private void FindMVCBooks(List<Book> books, IFileLogger logger)
        {
            if (books.Count == 0) {
                logger.LogIntoFile("Empty book list!", MessageType.Warning);
                logger.CloseFile();
                return;
            }

            bool noMVCBookFound = true;

            foreach (var book in books)
            {
                if (book.KeyWords.Contains("MVC4") || book.Title.Contains("MVC"))
                {
                    noMVCBookFound = false;
                    //LOG into the console
                    //Console.WriteLine("I need this book: " + book.Title);
                    string message = "I need this book: " + book.Title;
                    logger.LogIntoFile(message);
                }
            }

            if (noMVCBookFound) {
                logger.LogIntoFile("No MVC book found!", MessageType.Warning);
            }

            logger.CloseFile();
        }
    }
}
