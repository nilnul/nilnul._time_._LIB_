using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time.betwixt_.anchored_
{
	/// <summary>
	/// from now on; the shift can be negative or zero.
	/// </summary>
	static public class _HenceX
	{

		static public (DateTime start, DateTime stopage) _Borders_0minuts(
			int minutes
		) {

			var now = DateTime.Now;

			return (now, now.AddMinutes(minutes));
		}

		static public (DateTime start, DateTime stopage) _Borders_0hours(
			int hours
		) {

			var now = DateTime.Now;

			return (now, now.AddHours(hours));
		}

		static public (DateTime start, DateTime stopage) _Borders_0days(
			int days
		) {

			var now = DateTime.Now;

			return (now, now.AddHours(days));
		}






	}
}
