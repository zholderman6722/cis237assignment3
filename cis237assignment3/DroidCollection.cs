﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class DroidCollection
    {
        IDroid[] droidCollection;
        int droidCollectionLength;

        public DroidCollection(int size)
        {
            droidCollection= new IDroid[size];
            droidCollectionLength = 0; 
        }
        public void addNewDroid()
        {

        }
        
    }
}
