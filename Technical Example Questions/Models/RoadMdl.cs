using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technical_Example_Questions.Models
{
    public class RoadMdl
    {
        /// <summary>
        /// assign the road values
        /// </summary>
        /// <param name="T"> the town where the road ends</param>
        /// <param name="D"> the length of the road</param>
        public RoadMdl(TownMdl T, int D)
        {
            ToTown = T;
            Disatance = D;
        }

        public TownMdl ToTown { get; private set; } // where does this road end
        public int Disatance { get; private set; } //how long is the road
    }
}
