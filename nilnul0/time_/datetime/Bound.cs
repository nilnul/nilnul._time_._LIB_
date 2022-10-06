using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time_.datetime
{
	/// <summary>
	/// a duo of time, the left is always le the right.
	/// This is different from TimeSpan in that:
	///		1) period 's start and end is time; timespan only cares the length, not the starting point.
	/// </summary>
	public class Bound: nilnul.time_.datetime.border.co.be_.seeded.vow.Ed
	{
		
		public Bound(border.Co duo):base(duo)
		{
		}
		public Bound(Border border,Border border1):this( new datetime.border.Co(border,border1))
		{
		}

		static public Bound CreateClose(DateTime dateTime, DateTime dateTime1) {
			return new Bound(
				Border.CreateClose(dateTime)
				,
				Border.CreateClose(dateTime1)
			);
		}
		static public Bound CreateClose(string dateTime, string dateTime1) {
			return CreateClose(DateTime.Parse(dateTime), DateTime.Parse(dateTime1));
		}

		public bool contain(DateTime time) {
			return nilnul.time_.datetime.border.co.be_.Contain.Eval(this.ed, time);
		}
	}
}
