using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Utility : Droid
    {
        protected bool _toolbox;
        protected bool _computerConnection;
        protected bool _arm;

        //Constructors: 6 parameter constructor (string, string, string, bool, bool, bool)
	    //Uses the base class (Droid) constructor
        public Utility(String material, string model, string color, bool toolbox, bool computerConnection, bool arm)
            : base (material, model, color)
        {
            _toolbox = toolbox;
            _computerConnection = computerConnection;
            _arm = arm;
        }
        public override string ToString()
        {
            String tempString = base.ToString();
            if (_toolbox)
            {
                tempString += "Tool Box: " + _toolbox + Environment.NewLine;
            }
            if(_computerConnection)
            {
                tempString += "Computer Connection: " + _computerConnection + Environment.NewLine;
            }
            if(_arm)
            {
                tempString += "Arm: " + _arm + Environment.NewLine;
            }
            return tempString;
        }
        public override void CalculateTotalCost()
        {
            
        }
    }
}
