using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlutProjekt
{
    class ImmuneCell:Cell
    {
        public override List<string> Abilities()
        {
           
            List<string> abilityList = new List<string>() {"Phagocytosis", "Endocytosis", "Antibodies" };
            return abilityList;
        }
        
        public override string Description()
        {
            return "A cell that is part of the immune system and helps the body fight infections and other diseases. Immune cells develop from stem cells in the bone marrow and become different types of white blood cells. These include neutrophils, eosinophils, basophils, mast cells, monocytes, macrophages, dendritic cells, natural killer cells, and lymphocytes (B cells and T cells).";
            
        }


    }
}
