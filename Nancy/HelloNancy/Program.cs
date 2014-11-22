﻿using System;
using Nancy.Hosting.Self;
using HelloNancy.Repository;
using HelloNancy.DAL;
using System.Linq;
using System.Collections.Generic;

namespace HelloNancy
{
    class Program
    {
        static void Main(string[] args)
        {
            var uri =
                new Uri("http://localhost:3579");

            using (var host = new NancyHost(uri))
            {
                host.Start();

                Console.WriteLine("Your application is running on " + uri);
                Console.WriteLine("Press any [Enter] to close the host.");              
                Console.ReadLine();
            }
        }
    }
}
