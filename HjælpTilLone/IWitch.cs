using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HjælpTilLone
{
    internal interface IWitch : IDieFightHeal
    {
        void RaiseShield();
        void ShieldGlare();
        void Teleport(int x, int y);
    }
}
