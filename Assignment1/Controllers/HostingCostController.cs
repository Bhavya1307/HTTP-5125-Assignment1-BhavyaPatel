using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{

    //<summary>
    //Recieves a number of fornight and will apply charges and hst to that and will show the total bill.
    //</summary>
    //<param name="id">Number of fornight</param>
    //<param name="forNightCost">Cost per fornight which is 5.50$</param>
    //<param name="hst">HST which is 13%</param>
    //<param name="forNight">It will count the fornight (eg. 14 days = 1 fornight, 28 days = 2 fornight)</param>
    //<param name="subTotal">Amount after appying the cost per fornight to the number of fornight</param>
    //<param name="finalHST">Amount after applying hst on the sub total</param>
    //<param name="total">Final amount after adding sub total to the final hst</param>
    //<return>
    //It will return the total bill for the person.
    //</return>
    //<example>
    //GET api/HostingCost/0 => 1 fornights at $5.5/FN = $5.5 CAD HST 13% = $0.715 CAD Total = $6.215 CAD
    //</example>
    //<example>
    //GET api/HostingCost/14 => 2 fornights at $5.5/FN = $11 CAD HST 13% = $1.43 CAD Total = $12.43 CAD
    //</example>
    //<example>
    //GET api/HostingCost/15 => 2 fornights at $5.5/FN = $11 CAD HST 13% = $1.43 CAD Total = $12.43 CAD
    //</example>
    //<example>
    //GET api/HostingCost/28 => 3 fornights at $5.5/FN = $16.5 CAD HST 13% = $2.145 CAD Total = $18.645 CAD
    //</example>

    public class HostingCostController : ApiController
    {
        public string Get(int id)
        {
            double forNightCost = 5.50;
            double hst = 0.13;
            int forNight = (id / 14) + 1;
            double subTotal = (forNight * forNightCost);
            double finalHST = (subTotal * hst);
            double total = (subTotal + finalHST);

            string bill = forNight + " fornights at " + forNightCost + "/FN = " + subTotal + " CAD    " + "HST 13% = " + finalHST + " CAD   " + "Total = " + total + " CAD";
            return bill;
        }
    }
}
