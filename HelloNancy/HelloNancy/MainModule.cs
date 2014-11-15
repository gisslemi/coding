using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloNancy
{
    public class MainModule : NancyModule
    {
        public MainModule()
        {
            //Get["/"] = x => "Hello World";
            Get["/"] = x => {
                return View["index"];
            };
            
        }
    }
}
