using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{

    //<summary>
    //Recieves a number and will greet to that many people.
    //</summary>
    //<return>
    //It will return a string greeting to the number of people which has been entered.
    //</return>
    //<param name="id">Number of people to be greeted.</param>
    //<exmaple>
    //GET api/Greeting/10 => "Greetings to 10 people!"
    //</example>
    //<exmaple>
    //GET api/Greeting/5 => "Greetings to 5 people!"
    //</example>
    //<exmaple>
    //GET api/Greeting/500 => "Greetings to 500 people!"
    //</example>

    public class GreetingController : ApiController
    {
        public string Get(int id)
        {
            string greetings = "Greetings to " + id + " people!";
            return greetings;
        }
    }
}
