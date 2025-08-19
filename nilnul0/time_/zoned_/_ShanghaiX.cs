using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time_.zoned_
{
	static public class _ShanghaiX
	{
		static public DateTimeOffset ToShanghai(
			this DateTime localTime
		) {
			return 		new DateTimeOffset(
					localTime, nilnul.time_._zoned.zone_._ShanghaiX.Timespan
			);
		}
	}
}