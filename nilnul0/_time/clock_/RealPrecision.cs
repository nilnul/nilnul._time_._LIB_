using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._time.clock_
{
	/// <summary>
	/// upon DateTime's tick ( 100nanosecond ), we can append a timespan which is a real number in the unit measure of tick (100nanosecond).
	/// or we choose other unit than tick here. or reinterpret the tick as something other than "100nanosecond"
	/// </summary>
	interface IRealPrecision
	{
		
	}
}
