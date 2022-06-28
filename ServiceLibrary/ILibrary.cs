using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ServiceModel;

namespace ServiceLibrary
{
    [ServiceContract]
    internal interface ILibrary
    {
        [OperationContract]
        [FaultContract(typeof(ErrorHandler))]
        Book GetBookById(int id);

        [OperationContract]
        [FaultContract(typeof(ErrorHandler))]
        List<Book> GetBookByTitle(string title);

        [OperationContract]
        [FaultContract(typeof(ErrorHandler))]
        List<Book> GetBookByAuthor(string author);

        [OperationContract]
        string Output(Book book);
    }
}
