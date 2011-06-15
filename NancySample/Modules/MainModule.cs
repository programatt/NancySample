using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;
using Nancy.ViewEngines.Razor;

namespace NancySample.Modules
{
    public class MainModule: NancyModule
    {
        public MainModule()
        {
            //Canonical hello world path
            Get["/"] = parameters =>
                               {
                                   return "Hello World!";
                               };
         
            //Example of parameter capturing 
            Get["/DoStuff/{name}"] = req =>
                                         {
                                             return "Hello " + req.name;
                                         };
        }

    }
}