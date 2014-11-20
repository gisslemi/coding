namespace NineStars
{
    using Nancy;

    public class IndexModule : NancyModule
    {
        public IndexModule()
        {
            Get["/"] = parameters =>
            {
                return View["index"];
            };

            Get["/index.html"] = parameters =>
            {
                return View["index"];
            };
        }
    }
}