using nilnul.num.real_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._time._clock._measure.unit_
{
	public class Day4dbl
		: Unit4dblI
	{
		/// <summary>
		/// in seconds
		/// </summary>
		public const int MAGNITUDE = 24 *Hour4dbl.MAGNITUDE;
		public PositiveDblI magnitude =>new PositiveDbl(MAGNITUDE);
	}
}
