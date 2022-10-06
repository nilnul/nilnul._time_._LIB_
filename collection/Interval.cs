using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.cosmo.time
{

	/// <summary>
	/// from a point of time to a point of time.
	/// </summary>
	public partial class Interval:IntervalI
	{

		public Interval(Datetime start)
		{
			this.start = start;
			this.end = null;
		}
		public Interval(TimeI start,TimeI end)
		{
			this.start = start;
			this.end = end;
		}

		#region TimePeriodI Members
		public TimeI start
		{
			get
			;
			set
			;
		}

		public TimeI end
		{
			get
			;
			set
			;
		}

		#endregion

		#region SetI<TimeI> Members

		public bool? hasElement(TimeI element)
		{
			throw new NotImplementedException();
		}

		#endregion
	}
}
