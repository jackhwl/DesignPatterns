using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Houses
{
    public class LandOwner
    {
        private int totalHouses;
        private Painter painter;
        public LandOwner(int totalHouses)
        {
            this.totalHouses = totalHouses;
            this.painter = new Painter(4);
        }
        public void MaintainHouses()
        {
            this.painter.Paint(this.totalHouses);
        }
    }
}
