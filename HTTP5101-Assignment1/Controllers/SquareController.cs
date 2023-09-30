using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101_Assignment1.Controllers
{
    public class SquareController : ApiController
    {
        /// <summary>
        /// Returns the square of the provided integer.
        /// </summary>
        /// <param name="id">The integer for which the square will be calculated.</param>
        /// <returns>The square of the input integer.</returns>
        /// <example>
        /// GET http://localhost/api/Square/2
        /// Returns: 4
        /// </example>


        public int GET(int id)
        {

            int square = id * id;

            return square;
        }
    }
}
