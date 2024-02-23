using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CsharpA2.Controllers
{
    public class J1Controller : ApiController
    {
        ///<summary>
        /// Receives a point of Deliv-e-droid, a robot droid has to deliver packages while avoiding obstacles.
        ///</summary>
        ///<return>
        /// Gain 50 points for every package delivered.
        ///</return>
        ///<return>
        ///Lose 10 points for every collision with an obstacle.
        /// </return>
        /// <returns>
        ///  Earn a bonus 500 points if the number of packages delivered is greater than the number of collisions with obstacles.
        /// </returns>
        ///<example>
        /// GET api/Jone/Droid/5/2-> "730" 
        ///</example>
        ///<example>
        /// GET api/Jone/Droid/0/10 -> "-100"
        ///</example>
        ///
        [HttpGet]
        [Route("api/Jone/Droid/{TryNumber}/{Collisions}")]
        public int Droid(int TryNumber, int Collisions)
        {
            int GaindDelivered = 50;
            int LoseDelivered = -10;
            int BonuesDelivered = 500;
            int TotalPoints = TryNumber * GaindDelivered + Collisions * LoseDelivered;
            if (TryNumber >= Collisions) return TotalPoints + BonuesDelivered;
            else return TotalPoints;
        }
    }
}

