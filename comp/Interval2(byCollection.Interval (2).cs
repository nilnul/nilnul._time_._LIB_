using nilnul.order.interval;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.time.order
{
	public partial class Interval
		:nilnul.order.total.finite.Interval<DateTime,LessThanOrEqualTo>

	{



		public Interval(Cut2<DateTime> left, Cut2<DateTime> right)
			:base(left,right)
		{
		}
					
					
					
		
		
	}
}
