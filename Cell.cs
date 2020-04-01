using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlutProjekt
{
    abstract class Cell
    {
        public virtual Dictionary(string, Cell) Info(int cellType)
        {
            Dictionary<string, Cell> cellInfo = new Dictionary<string, Cell>();
            cellInfo.Add("ImmuneCell", "A cell that is part of the immune system and helps the body fight infections and other diseases. Immune cells develop from stem cells in the bone marrow and become different types of white blood cells. These include neutrophils, eosinophils, basophils, mast cells, monocytes, macrophages, dendritic cells, natural killer cells, and lymphocytes (B cells and T cells).");
            cellInfo.Add("Antigen", "A toxin or other foreign substance which induces an immune response in the body, especially the production of antibodies.");
            return cellInfo["ImmuneCell"];

        }
        public abstract string Description();
        

    }
   

   
}
