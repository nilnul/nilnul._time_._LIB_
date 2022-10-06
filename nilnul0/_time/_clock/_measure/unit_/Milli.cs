using nilnul.num.real_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._time._clock._measure.unit_
{
	public class Milli4dbl
		: Unit4dblI
	{
		/// <summary>
		/// in seconds
		/// </summary>
		public const double MAGNITUDE = nilnul.num.real_.quotient_._UnitalX.MILLI4DBL;
		public PositiveDblI magnitude =>new PositiveDbl(MAGNITUDE);
	}
}
