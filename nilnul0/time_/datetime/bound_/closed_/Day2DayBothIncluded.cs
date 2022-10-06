using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.time_.datetime.border;

namespace nilnul.time_.datetime.bound_.closed_
{
	public class Day2DayBothIncluded : nilnul.time_.datetime.Bound
	{
		public Day2DayBothIncluded(bound_.Day start, bound_.Day end ) : base(
				Co.CreateClose(
					start.start
					,end.startOfNextDay
				)
			
			)
		{
		}

		public Day2DayBothIncluded(int year, int month, int day, int endYear, int endMonth, int endDay):this(
			new bound_.Day(year,month,day), new Day(endYear,endMonth,endDay)
		)
		{

		}

		public Day endDay{
			get {
				return new Day(ed.right.mark.AddDays(-1));
			}
		}

		public Day startDay{
			get {
				return new Day(ed.left.mark);
			}
		}

		static public Day2DayBothIncluded CreateTilToday(int year, int month, int day) {
			return new Day2DayBothIncluded(
				new bound_.Day(year,month,day)
				,
				Day.CreateToday()
			);
		}




		


	}
}
