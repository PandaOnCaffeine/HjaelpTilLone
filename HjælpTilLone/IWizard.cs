using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HjælpTilLone
{
    internal interface IWizard : IDieFightHeal
    {
        void ThrowMagicMisile();
        void ThrowFrostNova();
        void Teleport(int x, int y);
    }
}
