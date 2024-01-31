using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class NumberMachineController : ApiController
    {
        //<summary>
        //Recieves a number and will perform 4 different mathemetical operations on it.
        //</summary>
        //<param name="id">The number on which the mathemetical operations will be performed.</param>
        //<return>
        //It will return the value after adding, subtracting, multiplying and dividing the number by 10.
        //</return>
        //<example>
        //GET api/NumberMachine/10 => Addition = 20 Subtraction = 0 Multiplication = 100 Division = 1
        //</example>
        //<example>
        //GET api/NumberMachine/100 => Addition = 110 Subtraction = 90 Multiplication = 1000 Division = 10
        //</example>
        //<example>
        //GET api/NumberMachine/50 => Addition = 60 Subtraction = 40 Multiplication = 500 Division = 5
        //</example>

        public string Get(int id)
        {
            int add = id + 10;
            int sub = id - 10;
            int mul = id * 10;
            int div = id / 10;
            return $" Addition = {add}" +
                $" Subtraction = {sub}" +
                $" Multiplication = {mul}" +
                $" Division = {div}";
        }
    }
}
