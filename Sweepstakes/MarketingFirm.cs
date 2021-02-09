﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class MarketingFirm
    {
        //Member Variables
        private ISweepstakesManager manager;

        //Constructor
        public MarketingFirm(ISweepstakesManager manager)
        {
            this.manager = manager;
            
        }

        //Member Methods
        public void CreateSweepstakes()
        {
            string sweepstakesName = UserInterface.GetUserInputFor("Whats your sweepstakes name?");
            Sweepstakes sweepstakes = new Sweepstakes(sweepstakesName);

        }
    }
}
