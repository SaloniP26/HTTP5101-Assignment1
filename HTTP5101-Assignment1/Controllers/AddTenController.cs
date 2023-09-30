using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101_Assignment1.Controllers
{
    public class AddTenController : ApiController
    {
        /// </summary>
        /// <param name="id">The integer to which 10 will be added.</param>
        /// <returns>The result of adding 10 to the input integer.</returns>
        /// <example>
        /// GET http://localhost/api/AddTen/21
        /// Returns: 31
        /// </example>


        public int GET(int id)
        {

            int addten = id + 10;

            return addten;
        }
    }
}
