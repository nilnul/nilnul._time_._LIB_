using nilnul.num.real_;
using nilnul.time.seg._measure.unit_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time.duration_
{
	public class Hours4dbl
		:
		Duration4dbl<seg._measure.unit_.Hour4dbl>
	{
		public Hours4dbl(NonnegOfDoubleI amount) : base(amount, Hour4dbl.Singleton )
		{
		}

		public Hours4dbl(NonnegOfDouble amount) : base(amount, Hour4dbl.Singleton)
		{
		}

		public Hours4dbl(double x) : base(x, Hour4dbl.Singleton)
		{
		}

		static public Hours4dbl Of<T>(Duration4dblI<T> x)
			where T : seg._measure.Unit4dblI


		{

			return x switch
			{
				 Hours4dbl a=> a
				 ,
				 var y when y.unit is seg._measure.unit_.Hour4dbl => new  Hours4dbl(y.amount)
				 ,
				 _=> new Hours4dbl(
					 x.amount.realee.ee * x.unit.magnitude.dblen.ee
					 /
					 Hour4dbl.Singleton.magnitude.dblen.ee
				)
			};

		}

	}
}
