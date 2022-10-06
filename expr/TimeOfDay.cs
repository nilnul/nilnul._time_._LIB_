using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.time
{
	public partial class TimeOfDay : TimeOfDayI
		,IComparable<TimeOfDayI>
	{
		public int hour
		{
			set;
			get;
		}

		public int minute
		{
			get;
			set;
		}

		public decimal seconds { get; set; }

		public TimeOfDay(int hour,int minute,decimal seconds)
		{
			this.hour = hour;
			this.minute = minute;
			this.seconds = seconds;
		}

		public TimeOfDay(int h)
			:this(h,0,0)
		{

		}


		#region IComparable<TimeOfDayI> Members

		public int CompareTo(TimeOfDayI other)
		{
			throw new NotImplementedException();
		}

		#endregion
	}
}
