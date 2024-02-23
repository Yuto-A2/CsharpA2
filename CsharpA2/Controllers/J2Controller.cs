using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CsharpA2.Controllers
{
    public class J2Controller : ApiController
    {
        ///<summary>
        /// This adds spiciness depending on the type of peppers.
        ///</summary>
        ///<return>
        /// The number of spices used and the level of spiciness.
        ///</return>
        ///<example>
        /// GET api/J2/CookingChili/1/Poblano -> "1/1500" 
        ///</example>
        ///<example>
        /// GET api/J2/CookingChili/1/Mirasol -> "1/6000"
        ///</example>
        //////<example>
        /// GET api/J2/CookingChili/1/Serrano -> "1/15500"
        ///</example>

        [HttpGet]
        [Route("api/J2/CookingChili/{number}/{peppers}")]

        //It was hard to define the spiciness of each pepper individually and directly add the spiciness corresponding to the given pepper names provided as input.
        // Could you give me feedback about it?
        public string CookingChili(int number, string peppers)

        {

            int TotalSpicy = 0;
            int PoblanoLevel = 1500;
            int MirasolLevel = 6000;
            int SerranoLevel = 15500;
            int CayenneLevel = 40000;
            int ThaiLevel = 75000;
            int HabaneroLevel = 125000;

            for (int i = 0; i < number; i++)
                if (peppers == "Poblano")
                {
                    TotalSpicy += PoblanoLevel;
                }
            if (peppers == "Mirasol")
            {
                TotalSpicy += MirasolLevel;
            }
            if (peppers == "Serrano")
            {
                TotalSpicy += SerranoLevel;
            }
            if (peppers == "Cayenne")
            {
                TotalSpicy += CayenneLevel;
            }
            if (peppers == "Thai")
            {
                TotalSpicy += ThaiLevel;
            }
            if (peppers == "Habanero")
            {
                TotalSpicy += HabaneroLevel;
            }
            return TotalSpicy.ToString();
        }
    }
}

