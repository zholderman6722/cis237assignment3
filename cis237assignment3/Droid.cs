﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    abstract class Droid : IDroid
    {
        //list of variables required for droid class
        protected string _material;
        protected string _model;
        protected string _color;
        protected decimal _baseCost;
        protected decimal _totalCost;

        //Constructors: 3 parameter constructor (string, string, string)
        public Droid(string material, string model, string color)
        {
            _material = material;
            _model = model;
            _color = color;
        }

        //public property Property: TotalCost to return the cost of the droid (Required by the interface)
        public decimal TotalCost
        {
            get
            {
                return _totalCost;
            }

            set
            {
                _totalCost = value;
            }
        }
        public abstract void CalculateTotalCost();

        //CalculateBaseCost: Determines the baseCost based on material and type.
        public virtual void CalculateBaseCost()
        {
                
        }



    }
}
