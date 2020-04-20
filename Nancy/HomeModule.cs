using System;
using Nancy;
using Nancy.Json;

namespace NancyAPI
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get("/hello", _ => { return GetHello(); });
            Get("/", _ => "Welcome the future son. Nancy the framework you wish you knew about as a kid.");
        }

        public string GetHello()
        {
            string returnval = "";
            //
            object[] people = new object[2];
            // ==> 
            people[0] = 21;
            people[1] = "John";
            //
            foreach(var item in people)
            {
                returnval += item.ToString();
            }
            //
            return returnval;
        }
    }

    public class Fire
    {
        private string _args;
        //
        public Fire(string args)
        {
            _args = args;
        }
        
        public Reply Return()
        {
            return new Reply()
            {
                Name = _args
            };
        }
    }

    public class Reply
    {

        public string Name { get; set; }
    }
}