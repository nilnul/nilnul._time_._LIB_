using nilnul.num.real_;
using nilnul.time.seg._measure.unit_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time.duration_
{
	/// <summary>
	/// ticks
	/// </summary>
	public class Decanano4dbl
		:
		Unit4dblDefault<seg._measure.unit_.DecaNano4Dbl>
	{
		public Decanano4dbl(NonnegOfDoubleI amount) : base(amount )
		{
		}

		

		public Decanano4dbl(double x) : base(x)
		{
		}
	}
}
