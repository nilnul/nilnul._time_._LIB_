using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.time.v111222
{
	public partial struct ChineseMonthLeaped
	{
		public bool isLeap;
		public int month;

		public ChineseMonthLeaped(bool isLeap,int month)
		{
			this.isLeap = isLeap;
			this.month = month;
		}
					

	}
}
