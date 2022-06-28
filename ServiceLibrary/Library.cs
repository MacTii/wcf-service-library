using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ServiceModel;
using System.Runtime.Serialization;

namespace ServiceLibrary
{
    public class Library : ILibrary
    {
        [DataMember]
        List<Book> books = new List<Book>()
        {
            new Book(1,"Harry Potter",new List<Author> {new Author("Joanne Murray", "Rowling") }),
            new Book(2,"Prorok",new List<Author> {new Author("Gibran", "Khalil") }),
            new Book(3,"Dublerka",new List<Author> {new Author("Clare", "Mackintosh"),new Author("Sophie", "Hannah") }),
            new Book(4,"Wiedzmin",new List<Author> {new Author("Andrzej","Sapkowski") })
        };

        public string Output(Book book)
        {
            string author = "";
            foreach (Author temp in book.Authors)
                author += temp.Name + " " + temp.Surname + "\n";

            return book.Title + "\nAuthors:\n" + author;
        }

        public Book GetBookById(int id)
        {
            if (books.FirstOrDefault(x => x.BookId == id) == null)
                throw new FaultException<ErrorHandler>(new ErrorHandler("Id not found"), new FaultReason("Invalid ID"));
            else
                return books.FirstOrDefault(x => x.BookId == id);
        }

        public List<Book> GetBookByTitle(string title)
        {
            if (books.FindAll(x => x.Title.Equals(title)).Count == 0)
                throw new FaultException<ErrorHandler>(new ErrorHandler("Title not found"), new FaultReason("Invalid TITLE"));
            else
                return books.FindAll(x => x.Title.Contains(title));
        }

        public List<Book> GetBookByAuthor(string author)
        {
            List<Book> authorBooks = books.FindAll(x => x.Authors.FindAll(y => y.Equals(author)).Count > 0);
            if (authorBooks.Count == 0)
                throw new FaultException<ErrorHandler>(new ErrorHandler("Author not found"), new FaultReason("Invalid AUTHOR"));
            return authorBooks;
        }
    }
}
