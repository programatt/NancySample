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
            Func<string, string> DoStuff = (name) =>
                                               {
                                                   return "Hello " + name;
                                               };

        Get["/"] = parameters =>
                           {
                               return "Hello World!";
                           };
            Get["/DoStuff/{name}"] = (name) =>
                                         {
                                             return DoStuff(name);
                                         };
        }

    }
}