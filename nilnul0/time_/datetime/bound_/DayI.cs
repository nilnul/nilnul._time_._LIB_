using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time_.datetime.bound_
{
	public interface DayI
	{
		
	}

	public class Day: nilnul.obj.Adapter<DateTime>, DayI
	{
		

		public Day(DateTime datetime):base(datetime)
		{
		}

		public Day(int year, int month, int day)
			:this(new DateTime(year,month,day))
		{

		}

		public int year {
			get {
				return _val.Year;
			}
		}

		public int month {
			get {
				return _val.Month;
			}
			set {
			}
		}
		public int day {
			get {
				return _val.Day;
			}
		}

		public DateTime startOfNextDay {
			get { return start.AddDays(1); } /*hour
			Type: System..::..Int32
The hours (0 through 23). */
		}

		public DateTime start {
			get { return new DateTime(year,month,day,0,0,0 ); }
		}


		public override string ToString()
		{
			return $@"{year}\{month}\{day}";
		}

		static public Day CreateToday() {
			return new Day(DateTime.Now);
		}
	}

	
}
