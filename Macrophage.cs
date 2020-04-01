using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlutProjekt
{
    class Macrophage:ImmuneCell
    {
        public override Dictionary<Cell, string> Info(int cellType)
        {
            cellInfo.Add(new Macrophage(), "In the big picture of things, macrophages can ingest and destroy bacteria, clean up cellular debris and other harmful particles, as well as dead cells that contain microbes, such as bacteria or viruses." +
                " After macrophages ingest these dead cells, they will take some of the material from the microbe inside the cell—a snapshot of the intruder if you will—and present it to other cells in the immune system. " +
                "In this way, macrophages can sound the alarm that a foreign invader is in the body and help other immune cells recognize that invader.");

        }
    }
}
