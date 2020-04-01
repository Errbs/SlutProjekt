using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlutProjekt
{
    class CytotoxicTCell:ImmuneCell
    {
        public override Dictionary<Cell, string> Info(int cellType)
        {
            cellInfo.Add(new CytotoxicTCell(), "Cytotoxic T-cells: Cytotoxic T-cells find and directly attack foreigners such as bacteria, viruses, and cancer cells.");
        }
    }
}
