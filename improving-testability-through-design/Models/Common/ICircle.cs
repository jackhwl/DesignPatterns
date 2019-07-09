using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Common
{
	public interface ICircle
	{        
		decimal X { get; set; }
        decimal Y { get; set; }
        decimal Radius { get; set; }
	}
}
