using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Protocol : Droid
    {
        protected int _numofLanguages;
        protected const decimal _costperLanguage = 10;

        public Protocol(string material, string model, string color, int numofLanguages)
            : base(material, model, color)
        {
            _numofLanguages = numofLanguages;
        }
        public override void CalculateTotalCost()
        {
          
        }
    }
}
