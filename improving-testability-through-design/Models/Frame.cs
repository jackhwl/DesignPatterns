using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Frame
    {
        private decimal length;
        private decimal width;

        public decimal Length 
        {
            get
            {
                return this.length;
            }
            set
            {
                if (value <= 0)
                    throw new System.ArgumentException("Length must be positive.", "value");
                this.length = value;
            }
        }

        public decimal Width 
        {
            get
            {
                return this.width;
            }
            set
            {
                if (value <= 0)
                    throw new System.ArgumentException("Width must be positive.", "value");
                this.width = value;
            }
        }

		public bool TryAddCircle(Common.ICircle circle)
		{
			if (circle.X < circle.Radius ||
                circle.X > this.length - circle.Radius ||
                circle.Y < circle.Radius ||
                circle.Y > this.width - circle.Radius)
                return false;
			return true;
		}
    }
}
