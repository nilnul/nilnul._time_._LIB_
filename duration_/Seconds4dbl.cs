using nilnul.num.real_;
using nilnul.time.seg._measure.unit_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time.duration_
{
	public class Seconds4dbl
		:
		Duration4dbl<seg._measure.unit_.Second4dbl>
	{
		public Seconds4dbl(NonnegOfDoubleI amount) : base(amount, Second4dbl.Singleton )
		{
		}

		public Seconds4dbl(NonnegOfDouble amount) : base(amount, Second4dbl.Singleton)
		{
		}

		public Seconds4dbl(double x) : base(x, Second4dbl.Singleton)
		{
		}
	}
}
