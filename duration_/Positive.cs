using nilnul.num.real_;
using nilnul.time.seg._measure.unit_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time.duration_
{
	public class Positive4dbl<T>
		: Duration4dbl<T>
		where T : seg._measure.Unit4dblI

	{
		

		public Positive4dbl(num.real_.PositiveDblI amount, T unit) : base(amount.dblen, unit)
		{
		}

		public Positive4dbl(num.real_.PositiveDbl amount, T unit) : base(amount, unit)
		{
		}

		public Positive4dbl(double x, T unit) : this(new PositiveDbl( x ), unit)
		{
		}


	}

	public class Positive4dbl : Positive4dbl<seg._measure.unit_.Second4dbl>
	{
		public Positive4dbl(PositiveDblI amount) : base(amount, Second4dbl.Singleton)
		{
		}

		public Positive4dbl(PositiveDbl amount) : base(amount, Second4dbl.Singleton)
		{
		}

		public Positive4dbl(double x) : base(x, Second4dbl.Singleton)
		{
		}
	}
}
