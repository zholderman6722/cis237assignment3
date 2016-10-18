using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Janitor : Utility
    {
        //list of variables
        protected bool _trashCompactor;
        protected bool _vacuum;

        //Constructors: 8 parameter constructor (string, string, string, bool, bool, bool, bool, bool)
	    //Uses the base class (Utility) constructor
        public Janitor(string material, string model, string color, bool toolbox, bool computerConnection, bool arm, bool trashCompactor, bool vacuum)
            : base(material, model, color, toolbox, computerConnection, arm)
        {
            _trashCompactor = trashCompactor;
            _vacuum = vacuum;
        }
        protected virtual void CalculateBaseCost
        {
            //Calculate totalCost by calculating the cost of each selected option and adds it to the base totalCost
        }
        public override string ToString()
        {
            string janitorialFeatures= base.ToString();
            if (_trashCompactor)
            {
                janitorialFeatures += "trash Compactor: " + _trashCompactor;
            }
            if (_vacuum)
            {
                janitorialFeatures += "vacuum: " + _vacuum;
            }
            return janitorialFeatures;
        }
    }
}
