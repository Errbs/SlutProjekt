using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlutProjekt
{
    
    class Antigen:Cell
    {
        public override string Info(int cellType)
        {
            Dictionary<Cell, string> cellInfo = new Dictionary<Cell, string>();
            cellInfo.Add(new PseudomonasAeruginosa(), "");
            cellInfo.Add(new StaphylococcusAureus(), "");
            cellInfo.Add(new InfluenzaA(), "");
            cellInfo.Add(new InfluenzaB(), "");

            return cellInfo[new InfluenzaA()];
        }


    }
}
