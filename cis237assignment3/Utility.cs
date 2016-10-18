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

        public Utility(String material, string model, string color, bool toolbox, bool computerConnection, bool arm)
            : base (material, model, color)
        {
            _toolbox = toolbox;
            _computerConnection = computerConnection;
            _arm = arm;
        }
    }
}
