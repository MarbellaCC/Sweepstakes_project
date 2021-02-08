using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Contestant
    {
        //Member Variables
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public int RegistrationNumber { get; set; }
       
        public Contestant()
        {
            FirstName = UserInterface.GetUserInputFor("What is your first name?");
            LastName = UserInterface.GetUserInputFor("What is your last name?");
            EmailAddress = UserInterface.GetUserInputFor("What is your email address?");
        }
    }
}
