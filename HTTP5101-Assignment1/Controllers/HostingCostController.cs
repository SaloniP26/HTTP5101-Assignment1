using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101_Assignment1.Controllers
{
    public class HostingCostController : ApiController
    {
        /// <summary>
        /// Calculates the hosting cost based on the number of days and includes HST (13%) in the total.
        /// </summary>
        /// <param name="id">The number of days of hosting.</param>
        /// <returns>3 strings describing the total hosting cost.</returns>
        /// <example>
        /// GET http://localhost/api/HostingCost/0
        /// Returns:
        /// "1 fortnight at $5.50/FN = $5.50 CAD"
        /// "HST 13% = $0.72 CAD"
        /// "Total = $6.22 CAD"
        /// </example>

        public string GET(int id)
        {
            double fortnightCost = 5.50;
            double hstRate = 0.13;
            int numberOfFortnights = id / 14 + 1;
            double totalCost = numberOfFortnights * fortnightCost;
            double hstAmount = totalCost * hstRate;
            double grandTotal = totalCost + hstAmount;

            return numberOfFortnights + " fortnight at $5.50/FN = " + totalCost + " CAD " + " HST 13% = $" + hstAmount + " CAD" + " Total = $" + grandTotal + " CAD";

        }
    }
}
