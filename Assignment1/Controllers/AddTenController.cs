using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{

    //<summary>
    //Recieves a number and will return it by adding 10 to that number.
    //</summary>
    //<param name="id">The value of number.</param>
    //<return>
    //Number added by 10.
    //</return>
    //<example>
    //GET api/AddTen/10 => 20
    //</example>
    //<example>
    //GET api/AddTen/17 => 27
    //</example>
    //<example>
    //GET api/AddTen/100 => 110
    //</example>

    public class AddTenController : ApiController
    {
        public int Get(int id)
        {
            int add = id + 10;
            return add;
        }
    }
}
