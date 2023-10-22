﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzuperhosProjekt
{
    public class Vasember : Bosszuallo, IMilliardos
    {
        private static Random RND = new Random();

        public Vasember() : base(150, true) {}
   
        public void KutyutKeszit()
        {
            double plus = RND.NextDouble() * 10;
            this.Szuperero += plus;
        }

        public override bool MegmentiAVilagot()
        {
            return this.Szuperero > 1000;
        }

        public override string ToString()
        {
            return $"Vasember: {base.ToString()}";
        }
    }
}
