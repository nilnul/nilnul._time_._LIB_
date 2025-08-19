using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time_._zoned.zone_
{
	static public  class _ShanghaiX
	{
		/// <summary>
		/// for Iana, it's shanghai, the most populous, not beijing.
		/// </summary>
		public const string IANA = "Asia/Shanghai";

		public const int OFFSET_IN_HOURS =8;
		/// <summary>
		/// positive for  zones east to Universal TimeZone;
		/// </summary>
		public const int OFFSET_IN_MINUTES =OFFSET_IN_HOURS*60;

		static public readonly	TimeSpan Timespan = TimeSpan.FromHours(
									OFFSET_IN_HOURS
				);


	}
}
