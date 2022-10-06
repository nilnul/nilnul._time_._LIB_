using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.time
{
	public partial class Time
	{
		static public int MinutesToMilliSeconds(int minutes) {
			return minutes * 60 * 1000;
		}
	}
}
