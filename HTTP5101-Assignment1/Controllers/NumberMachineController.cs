using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101_Assignment1.Controllers
{
    public class NumberMachineController : ApiController
    {

        /// </summary>
        /// <param name="id">The integer to which 10 will be added.</param>
        /// <returns>The result of adding 10 to the input integer.</returns>
        /// <example>
        /// GET http://localhost/api/NumberMachine/21
        /// Returns: 31
        /// </example>

        // GET api/NumberMachine/21

        public string GET(int id)
        {
            
            int addition = id + 10;
            int subtraction = id - 5;
            int multiplication = id * 4;
            int division = id / 2;

            return "Addition = " + addition + ", Subtraction = " + subtraction + ", Multiplication = " + multiplication + ", Division = " + division; 
           
        }
    }
}