using nilnul.num.real_;
using nilnul.time.seg._measure.unit_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time.duration_
{
	public class Days4dbl
		:
		Duration4dbl<seg._measure.unit_.Day4dbl>
	{
		public Days4dbl(NonnegOfDoubleI amount) : base(amount, Day4dbl.Singleton )
		{
		}

		public Days4dbl(NonnegOfDouble amount) : base(amount, Day4dbl.Singleton)
		{
		}

		public Days4dbl(double x) : base(x, Day4dbl.Singleton)
		{
		}
	}
}
