using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloNancy.Modules
{
    public class ApiModule : NancyModule
    {
        public ApiModule()
            : base("/api")
        {
            Get["/books/"] = parameters =>
            {
                string foo = "test";

                return Response.AsJson(foo);
            };

            Get["/books/{id}"] = parameters =>
            {
                string foo = "test " + parameters.id;

                return Response.AsJson(foo);
            };

            //Get["/people/collection"] = parameters =>
            //{
            //    var output = new PersonCollection();
            //    output.Fetch();

            //    return Response.AsJson(output);
            //};

            //Post["/people/add/"] = parameters =>
            //{
            //    //Declare initial response object
            //    ValidationResult result;

            //    //Create new model instance to bind to post data 
            //    var item = new personModel();

            //    //Prevalidate data from presentation layer
            //    result = item.Prevalidate(Request.Form);

            //    //Data is prevalidated, try to save the object
            //    if (result.Successful)
            //        result = item.Save();

            //    //Provide result
            //    return Response.AsJson(result);
            //};

            //Post["/people/{id}/edit/"] = parameters =>
            //{
            //    //Declare initial response object
            //    ValidationResult result;

            //    //Create new model instance to bind to post data 
            //    var item = new personModel(parameters.id);

            //    //Prevalidate data from presentation layer
            //    result = item.Prevalidate(Request.Form);

            //    //Data is prevalidated, try to save the object
            //    if (result.Successful)
            //        result = item.Save();

            //    //Provide result
            //    return Response.AsJson(result);
            //};

            //Post["/people/{id}/delete/"] = parameters =>
            //{
            //    //Declare initial response object
            //    ValidationResult result;

            //    //Create new model instance to bind to post data 
            //    var item = new personModel(parameters.id);

            //    //Delete the model / object
            //    result = item.Delete();

            //    //Provide result
            //    return Response.AsJson(result);
            //};

            //Get["/eye-colour/{id}"] = parameters =>
            //{
            //    var output = EyeColour.GetEyeColour((int)parameters.id);

            //    return Response.AsJson(output);
            //};

            //Get["/eye-colour/list"] = parameters =>
            //{
            //    var output = EyeColourList.GetList();

            //    return Response.AsJson(output);
            //};

            //Get["/eye-colour/collection"] = parameters =>
            //{
            //    var output = new EyeColourCollection();
            //    output.Fetch();

            //    return Response.AsJson(output);
            //};
        }
    }
}
