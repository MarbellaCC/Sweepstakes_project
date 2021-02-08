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
        public string FirstName
        {
            get => FirstName;
            set => FirstName = value;
        }
        public string LastName
        {
            get => LastName;
            set => LastName = value;
        }

        public string EmailAddress
        {
            get => EmailAddress;
            set => EmailAddress = value;
        }

        public int RegistrationNumber
        {
            get => RegistrationNumber;
            set => RegistrationNumber = value;
        }
    }
}
