using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.time
{
	public partial class HourMinuteSeconds : TimeOfDayI
		
		
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

		public HourMinuteSeconds(int hour,int minute,decimal seconds)
		{
			this.hour = hour;
			this.minute = minute;
			this.seconds = seconds;
		}

		public HourMinuteSeconds(int h)
			:this(h,0,0)
		{

		}

		/// <summary>
		/// the decimal part, say 10, stands for 10 of 60 minutes.
		/// </summary>
		/// <param name="hourMinute"></param>
		public HourMinuteSeconds(decimal hourMinute)
		{
			if (hourMinute<0 || hourMinute>24)
			{
				throw	new ArgumentOutOfRangeException("");
		 
			}
			this.hour = (int)hourMinute;
			this.minute =((int) (hourMinute - this.hour))*100;
			if (this.minute>=60)
			{
				throw new Exception("the decimal part must be in [0,60)");
				
			}
		}
					


		#region IComparable<TimeOfDayI> Members

		public int CompareTo(TimeOfDayI other)
		{
			throw new NotImplementedException();
		}

		#endregion
	}
}
