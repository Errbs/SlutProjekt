using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlutProjekt
{
    class BCell:ImmuneCell
    {
        public override List<string> Abilities() // maybe make these lists into dictionary<string, string>
        {
            List<string> abilityList = new List<string>() {"Antibodies"};
            return abilityList;
        }
        public override string Description()
        {
            return "B-cells can differentiate into plasma cells—the body's antibody-producing factories. " +
               "Plasma cells produce large proteins called immunoglobulins, or antibodies that attach to the surface of foreign agents. " +
               "These antibodies serve as flags or the flares over a battle site." +
               " They recruit other defensive molecules in the bloodstream to the site, working toward killing the infection-causing organism.";

        }
    }
}
