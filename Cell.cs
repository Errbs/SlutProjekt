using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlutProjekt
{
    abstract class Cell
    {
        public List<string> abilityList = new List<string>();
        public abstract List<string> Abilities();
        
        public abstract string Description();
        

    }
   

   
}
