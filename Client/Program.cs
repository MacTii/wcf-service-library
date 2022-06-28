using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

using Client.LibraryReference;

namespace Client
{
    internal class Program
    {
        static void Main(string[] args)
        {

            LibraryClient client = new LibraryClient();

            while (true)
            {
                try
                {
                    Console.WriteLine("Choose option:");
                    Console.WriteLine("1 - Get book by ID\n2 - Get book by TITLE\n3 - Get book by AUTHOR");
                    Console.Write("Option: ");
                    int option = int.Parse(Console.ReadLine());

                    if (option == 0)
                    {
                        break;
                    }
                    else if (option == 1)
                    {
                        Console.Write("Give id of book: ");
                        int bookId = int.Parse(Console.ReadLine());
                        Console.WriteLine(client.OutputAsync(client.GetBookByIdAsync(bookId).Result).Result);
                    }
                    else if (option == 2)
                    {
                        Console.Write("Give title of book: ");
                        string bookTitle = Console.ReadLine();
                        for (int i = 0; i < client.GetBookByTitleAsync(bookTitle).Result.Length; i++)
                        {
                            Console.WriteLine(client.OutputAsync(client.GetBookByTitleAsync(bookTitle).Result[i]).Result);
                        }
                    }
                    else if (option == 3)
                    {
                        Console.Write("Give author of book: ");
                        string bookAuthor = Console.ReadLine();
                        for (int i = 0; i < client.GetBookByAuthorAsync(bookAuthor).Result.Length; i++)
                        {
                            Console.WriteLine(client.OutputAsync(client.GetBookByAuthorAsync(bookAuthor).Result[i]).Result);
                        }
                    }
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }
            Console.ReadKey();
            client.Close();
        }
    }
}
