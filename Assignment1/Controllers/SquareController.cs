using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{

    //<summary>
    //Recieves a number and will return Sqaure of that number.
    //</summary>
    //<param name="id">The value of number.</param>
    //<return>
    //Square of the number.
    //</return>
    //<example>
    //GET api/Square/2 => 4
    //</example>
    //<example>
    //GET api/Square/5 => 25
    //</example>
    //<example>
    //GET api/Square/30 => 900
    //</example>

    public class SquareController : ApiController
    {
        public int Get(int id)
        {
            int square = id * id;
            return square;
        }
    }
}
