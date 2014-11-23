namespace HelloNancy
{
    using HelloNancy.Models;
    using Nancy;
    using System.Collections.Generic;
    using Repository;
    using HelloNancy.DAL;

    public class IndexModule : NancyModule
    {
        public IndexModule()
        {
            Get["/"] = parameters =>
            {
                return View["index"];
            };

            //Get["/books"] = parameters => {
            //    List<Book> bookList = Repo.GetAllBooks();
            //    return View["books", bookList];
            //};

            Get["/cars"] = parameters =>
            {
                List<Car> cars = new List<Car>();
                cars.Add(new Car { HorsePower=123, Make="BMW", YearOfBuild=2010 });
                cars.Add(new Car { HorsePower = 123, Make = "BMW", YearOfBuild = 2010 });
                cars.Add(new Car { HorsePower = 123, Make = "BMW", YearOfBuild = 2010 });
                cars.Add(new Car { HorsePower = 123, Make = "BMW", YearOfBuild = 2010 });
                return View["cars",cars];
            };
        }
    }
}