﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HjælpTilLone
{
    internal interface IBabarian : IDieFightHeal
    {
        void Bash();
        void Cleave();
        void Slash();
    }
}
