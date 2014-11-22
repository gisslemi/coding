using HelloNancy.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace HelloNancy.Repository
{
    public class Repo
    {
        public static void AddNewBook(Book book)
        {
            try
            {
                using (var context = new BooksEntities())
                {
                    
                    context.Books.Add(book);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<Book> GetAllBooks()
        {
            using (var context = new BooksEntities())
            {                
                var query = (from b in context.Books select b);
                List<Book> books = new List<Book>();
                foreach (Book book in query)
                {
                    books.Add(book);
                }             
                return books;
            }
        }

        public static Book GetBookById(int id)
        {
            using (var context = new BooksEntities())
            {
                    var query = (from b in context.Books where b.Id == id select b).FirstOrDefault();
                    return query;
            }
        }

        public static List<Book> GetBooksByAuthor(string author)
        {
            using (var context = new BooksEntities())
            {
                var query = (from b in context.Books where b.Author == author select b);
                List<Book> bookList = new List<Book>();
                if (query != null)
                {
                    foreach (Book book in query)
                    {
                        bookList.Add(book);
                    } 
                }
                return bookList;
            }
        }

        public static List<Book> GetBooksByTitle(string title)
        {
            using (var context = new BooksEntities())
            {
                var query = (from b in context.Books where b.Title == title select b);
                List<Book> bookList = new List<Book>();
                if (query != null)
                {
                    foreach (Book book in query)
                    {
                        bookList.Add(book);
                    }
                }
                return bookList;
            }
        }

        public static void RemoveBookById(int id)
        {
            using (var context = new BooksEntities())
            {
                var query = (from b in context.Books where b.Id == id select b).FirstOrDefault();
                if (query != null)
                {
                    context.Books.Remove(query);
                    context.SaveChanges();            
                }               
            }
        }

        public static void RemoveAllBooks()
        {
            using (var context = new BooksEntities())
            {
                var query = (from b in context.Books select b).FirstOrDefault();
                if (query != null)
                {
                    context.Books.Remove(query);
                    context.SaveChanges();
                }
            }
        }

    }
}
