using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101_Assignment1.Controllers
{
    public class Greeting2Controller : ApiController
    {
        /// <summary>
        /// Returns the square of the provided integer.
        /// </summary>
        /// <param name="id">The integer for which the greeting will be returned</param>
        /// <returns>Greeting to 3 people</returns>
        /// <example>
        /// GET http://localhost/api/Greeting2/3
        /// Returns: Greeting to 3 people!
        /// </example>
        /// 
        public string Get(int id)
        {
            return "Greeting to " + id + " people!";
        }
    }
}
