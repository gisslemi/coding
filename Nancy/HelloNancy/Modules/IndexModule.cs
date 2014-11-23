using HelloNancy.Models;
using Nancy;
using System.Collections.Generic;
using HelloNancy.DAL;
using HelloNancy.Repository;
using Nancy.ModelBinding;
namespace HelloNancy.Modules
{
    public class IndexModule : NancyModule
    {
        private IRepository booksRepo;

        public IndexModule()
        {
            this.booksRepo = new BooksRepository(new BooksDbContext());

            Get["/"] = x =>
            {
                return View["index"];
            };

            Get["/new"] = x =>
            {
                return View["new"];
            };           

            Get["/books"] = x =>
            {
                var result = booksRepo.GetBooks();
                return View["books", result];
            };

            Post["/new"] = paramters =>
            {
                if (Request.Form["title"].HasValue && Request.Form["author"].HasValue)
                {
                    var newBook = this.Bind<Book>();
                    booksRepo.InsertBook(newBook);
                    booksRepo.Save();
                }
                return Response.AsRedirect("/books");
            };  

            Put["/{id:int}"] = parameters =>
            {
                return HttpStatusCode.NotImplemented;
            };

            Delete["/{id:int}"] = x =>
            {
                booksRepo.DeleteBook(x.id);
                booksRepo.Save();
                return HttpStatusCode.OK;
            };
        }
    }
}