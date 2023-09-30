using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101_Assignment1.Controllers
{
    public class Greeting1Controller : ApiController
    {

        /// <summary>
        /// Returns the square of the provided integer.
        /// </summary>
        /// <param name="Greeting">The string for which the greeting will be returned</param>
        /// <returns>Greeting to 3 people</returns>
        /// <example>
        /// POST http://localhost/api/Greeting1
        /// Returns: Hello World!
        /// </example>
        /// 
        public string POST(string Greeting)
        {
            Greeting = "Hello World!";
            return Greeting;
        }
    }
}
