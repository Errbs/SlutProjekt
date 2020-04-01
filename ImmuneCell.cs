using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlutProjekt
{
    class ImmuneCell:Cell
    {
        public List<string> Abilities()
        {
            List<string> abilityList = new List<string>() {"Phagocytosis", "Endocytosis", "", "" };
            return abilityList;
        }
        public override string Info(int cellType)
        {

            Dictionary<Cell, string> cellInfo = new Dictionary<Cell, string>();
            cellInfo.Add(new Neutrophil(), "Neutrophils are a type of white blood cell (WBC or granulocyte) that protect us from infections, among other functions." +
                " They make up approximately 40 percent to 60 percent of the white blood cells in our bodies" +
                "﻿ and are the first cells to arrive on the scene when we experience a bacterial infection.");
            cellInfo.Add(new Macrophage(), "In the big picture of things, macrophages can ingest and destroy bacteria, clean up cellular debris and other harmful particles, as well as dead cells that contain microbes, such as bacteria or viruses." +
                " After macrophages ingest these dead cells, they will take some of the material from the microbe inside the cell—a snapshot of the intruder if you will—and present it to other cells in the immune system. " +
                "In this way, macrophages can sound the alarm that a foreign invader is in the body and help other immune cells recognize that invader.");
            cellInfo.Add(new CytotoxicTCell(), "Cytotoxic T-cells: Cytotoxic T-cells find and directly attack foreigners such as bacteria, viruses, and cancer cells.");
            cellInfo.Add(new BCell(), "B-cells can differentiate into plasma cells—the body's antibody-producing factories. " +
                "Plasma cells produce large proteins called immunoglobulins, or antibodies that attach to the surface of foreign agents. " +
                "These antibodies serve as flags or the flares over a battle site." +
                " They recruit other defensive molecules in the bloodstream to the site, working toward killing the infection-causing organism.");
            if (cellType < 1)
            {
                return cellInfo[new Neutrophil()];
            }
            else if (cellType > 1 && cellType < 2)
            {
                return cellInfo[new Macrophage()];
            }
            else
            {
                return cellInfo[new CytotoxicTCell()];
            }

          

            
        }


    }
}
