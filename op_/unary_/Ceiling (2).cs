using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using nilnul.number.uinteger;

namespace nilnul.time
{
	public partial class Ceiling
	{

		static private readonly Ceiling _Instance = new Ceiling();
		static public Ceiling Instance
		{
			get
			{
				return _Instance;
			}
		}
		private Ceiling()
		{
		}

		public DateTime eval(DateTime a, UnitI unit)
		{

			DateTime r;

			if (unit is Years)
			{
				Years unitAsYears = (Years)unit;



				var yearsForReturn = a.Year.Ceiling(unitAsYears.quantity).ToInt();

				r = new DateTime(yearsForReturn, 1, 1);

				if (r < a)
				{
					r.AddYears( unitAsYears.quantity.ToInt());

				}



			}
			else if (unit is YearDayHour)
			{
				YearDayHour ydh = (YearDayHour)unit;



				if (ydh.ymdhms == YMDHMS.Year)
				{
					r = new DateTime(a.Year, 1, 1);
					if (a != r)
					{
						r.AddYears(1);

					}


				}
				else if (ydh.ymdhms == YMDHMS.Month)
				{
					r = new DateTime(a.Year, a.Month, 1);

					if (a != r)
					{

						r.AddMonths(1);
					}


				}
				else if (ydh.ymdhms == YMDHMS.Day)
				{
					r = new DateTime(a.Year, a.Month, a.Day);
					if (a != r)
					{
						r.AddDays(1);

					}

				}
				else if (ydh.ymdhms == YMDHMS.Hour)
				{
					r = new DateTime(a.Year, a.Month, a.Day, a.Hour, 0, 0);
					if (a != r)
					{

						r.AddHours(1);

					}

				}
				else if (ydh.ymdhms == YMDHMS.Minute)
				{
					r = new DateTime(a.Year, a.Month, a.Day, a.Hour, a.Minute, 0);
					if (a != r)
					{
						r.AddMinutes(1);

					}

				}
				else if (ydh.ymdhms == YMDHMS.Second)
				{
					r = new DateTime(a.Year, a.Month, a.Day, a.Hour, a.Minute, a.Second);
					if (a != r)
					{
						r.AddSeconds(1);

					}

				}


			}
			else //seconds.
			{

				throw new Exception("unit cannot be less than a second.");

				//Seconds unitAsSeconds = (Seconds)unit;

				//r = new DateTime(a.Year, a.Month, a.Day, a.Hour, a.Minute, a.Second,a.Millisecond);
				//r.AddTicks(unitAsSeconds.denominator);



				//var yearsForReturn = a.Year.Ceiling(unitAsYears.quantity).ToInt();

				//r = new DateTime(yearsForReturn, 1, 1);

				//if (r < a)
				//{
				//    r.AddYears(unitAsYears.quantity.ToInt());

				//}


			}



		}
				

	}
	static public partial class CeilingX {

		static public DateTime Ceiling(this DateTime d, UnitI u) {



			if (u is Years)
			{
				Years uAsYears=(Years)u;

				


				var firstLineTime = new DateTime(
					(
						(uint)(d.Year)
					).Ceiling(
						(uint)(uAsYears.quantity)

					)
				);





			}
			
		}
	
	}
}
