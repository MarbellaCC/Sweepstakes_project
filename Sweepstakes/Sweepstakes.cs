using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Sweepstakes
    {
        //Member Variables
        private Dictionary<int, Contestant> contestants;
        private string name;
        public string Name
        {
            get => name;
            set => name = value;
        }

        //Constructor
        public Sweepstakes(string name)
        {
            this.name = name;
            contestants = new Dictionary<int, Contestant>();
        }

        //Member Methods
        public void RegisterContestant(Contestant contestant)
        {
            contestant.RegistrationNumber = contestants.Count;
            contestants.Add(contestants.Count, contestant);
        }

        public Contestant PickWinner()
        {
            Random random = new Random();
            int randomKey = random.Next(0, contestants.Count);

            foreach(KeyValuePair<int, Contestant> contestant in contestants)
            {
                if(randomKey == contestant.Key)
                {
                    return contestant.Value;
                }
            }
            return null;
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            foreach(KeyValuePair<int, Contestant> theContestant in contestants)
            {
                if(contestant == theContestant.Value)
                {
                    Console.WriteLine(theContestant.Key + " " + theContestant.Value);
                }
            }
        }
    }
}
