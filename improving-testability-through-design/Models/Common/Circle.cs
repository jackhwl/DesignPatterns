using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Common
{
	public class Circle : ICircle
	{
		public decimal X { get; set; }
		public decimal Y { get; set; }
		public decimal Radius { get; set; }

		public bool Equals(ICircle other)
		{
			return other != null && other.X == this.X && other.Y == this.Y && other.Radius == this.Radius;
		}
	}
}
