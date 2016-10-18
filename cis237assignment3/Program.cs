using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Userinterface ui = new Userinterface();
            DroidCollection droids = new DroidCollection(50);
            ui.DisplayMenu();
        }
    }
}
