using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CsharpA2.Controllers
{
    public class J3Controller : ApiController
    {
        ///<summary>
        /// If there is more than one day on which the largest number of people are able to attend,output all of these day numbers in increasing order and separated by commas
        ///</summary>
        ///<return>
        /// The most day when most people can attend the event.
        ///</return>
        ///<example>
        /// GET api/J2/CookingChili/1/y -> "1" 
        ///</example>

        [HttpGet]
        [Route("api/J3/SpecialEvent/{numOfInterested}/{availability}")]

        //It was hard to define "availability" individually as input.
        // Could you give me feedback about it?
        public string SpecialEvent(int numOfInterested, string availability)
        {
            int availableDays = 0;
            int bestDay = 0;

            for (int i = 0; i < 5; i++)
            {

                for (int x = 0; x < numOfInterested; x++)
                {
                    if (availability == "y")
                    {
                        availableDays++;

                    }
                    if (availableDays == numOfInterested)
                    {
                        bestDay++;
                    }

                }
            }
            return bestDay.ToString();
        }
    }
}
