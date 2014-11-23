using HelloNancy.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace HelloNancy.Repository
{
    public class Repo : HelloNancy.Repository.IRepository, IDisposable
    {
        private BooksDbContext context;

        public Repo(BooksDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Book> GetBooks()
        {
            return context.Books.ToList();  
        }

        public Book GetBookById(int id)
        {
            return context.Books.Find(id);
        }

        public void InsertBook(Book book)
        {
            context.Books.Add(book);
        }

        public void DeleteBook(int id)
        {
            Book book = context.Books.Find(id);
            context.Books.Remove(book);
        }

        public void UpdateBook(Book book)
        {
            context.Entry(book).State = EntityState.Modified;
        }

        public IEnumerable<Book> GetBooksByAuthor(string author)
        {        
            return context.Books.Where(b => b.Author == author).ToList();
        }

        public IEnumerable<Book> GetBooksByTitle(string title)
        {
            return context.Books.Where(b => b.Title == title).ToList();
        }
     
        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }       
    }
}
