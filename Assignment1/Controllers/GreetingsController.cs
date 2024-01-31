using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{

    //<summary>
    //Display Hello World! by using POST method.
    //</summary>
    //<return>
    //It will return a string saying "Hello World!".
    //</return>
    //<example>
    //curl -d "" http://localhost:59749/api/Greetings => "Hello World!"
    //</example>

    public class GreetingsController : ApiController
    {
        public String Post()
        {
            return "Hello World!";
        }
    }
}
