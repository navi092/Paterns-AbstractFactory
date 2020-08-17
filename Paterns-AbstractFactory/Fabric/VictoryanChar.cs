﻿using Paterns_AbstractFactory.Fabric;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paterns_AbstractFactory
{
    class VictoryanChar : IChair
    {
        private int _legs;
        private bool _sit;
        public VictoryanChar(int legs, bool sit)
        {
            _legs = legs;
            _sit = sit;
        }

        public int hasLegs()
        {
            return _legs;
        }

        public bool sitOn()
        {
            return _sit;
        }
    }
}
