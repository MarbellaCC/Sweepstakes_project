using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Simulation
    {
        //Member Methods
        public void CreateMarketingFirmWithManager()
        {
            ISweepstakesManager manager = null; //made manager equal to null so the error on line 38 goes away 
                                                //you define what type manager is w/ the switch statement
            UserInterface.GetUserInputFor("Would you like to use Queue or Stack?");
            string stackOrQueueProgram = Console.ReadLine();
            switch (stackOrQueueProgram)
            {
                case "Stack":
                    manager = new SweepstakesStackManager();
                    break;
                case "stack":
                    manager = new SweepstakesStackManager();
                    break;
                case "Queue":
                    manager = new SweepstakesQueueManager();
                    break;
                case "queue":
                    manager = new SweepstakesQueueManager();
                    break;
                default:
                    UserInterface.GetUserInputFor("Input invalid try again");
                    CreateMarketingFirmWithManager();
                    break;
            }

            MarketingFirm marketingFirm = new MarketingFirm(manager);
            marketingFirm.CreateSweepstakes();
        }
    }
}
