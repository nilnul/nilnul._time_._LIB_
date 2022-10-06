using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.cosmo.time
{
	public partial struct Datetime
		:TimeI
	{
		

		public System.DateTime dateTime
		{
			get;
			set;
		}

		public Datetime(System.DateTime dateTime)
		{
			this.dateTime = dateTime;
		}

		//public int year;
		//public int month;
		//public int dayOfMonth;
		//public int hour;
		//public int minute;
		//public decimal second;

		///others, 0, e.g., subseconds

		//public Time(int year,int month,int dayOfMonth,int hour,int minute,decimal second) {
		//    if (second >= 60 || second < 0)
		//    {
		//        throw new ArgumentOutOfRangeException();
		//    } 
			
		//    this.year = year;
		//    this.month = month;
		//    this.dayOfMonth = dayOfMonth;
		//    this.hour = hour;
		//    this.minute = minute;
			
		//    this.second = second;
		//}

		#region IComparable<TimeI> Members

		public int CompareTo(TimeI other)
		{
			throw new NotImplementedException();
		}

		#endregion

		
	}
}
