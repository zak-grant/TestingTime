using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingTime
{
    public class Reservation
    {
        public User MadeBy { get; set; }

        public bool CanBeCancelledBy(User user)
        {
            // Return true only is user.IsAdmin or madeBy is user
            return (user.IsAdmin || MadeBy == user);
        }
    }
}
