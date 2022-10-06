using nilnul.num.real_;
using nilnul.time.seg._measure.unit_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time.duration_
{
	public class Minutes4dbl
		:
		Duration4dbl<seg._measure.unit_.Minute4dbl>
	{
		public Minutes4dbl(NonnegOfDoubleI amount) : base(amount, Minute4dbl.Singleton )
		{
		}

		public Minutes4dbl(NonnegOfDouble amount) : base(amount, Minute4dbl.Singleton)
		{
		}

		public Minutes4dbl(double x) : base(x, Minute4dbl.Singleton)
		{
		}
	}
}
