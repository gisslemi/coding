using System;
namespace HelloNancy.Repository
{
    interface IRepository : IDisposable
    {
        void DeleteBook(int id);
        void Dispose();
        HelloNancy.DAL.Book GetBookById(int id);
        System.Collections.Generic.IEnumerable<HelloNancy.DAL.Book> GetBooks();
        System.Collections.Generic.IEnumerable<HelloNancy.DAL.Book> GetBooksByAuthor(string author);
        System.Collections.Generic.IEnumerable<HelloNancy.DAL.Book> GetBooksByTitle(string title);
        void InsertBook(HelloNancy.DAL.Book book);
        void Save();
        void UpdateBook(HelloNancy.DAL.Book book);
    }
}
