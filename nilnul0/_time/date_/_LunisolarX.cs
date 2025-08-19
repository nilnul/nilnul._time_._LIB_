using System;
using System.Globalization;
using C = nilnul._time._date.calendar_._ChineseLunisolarX;
using D = (int year, bool leap, int month, int day);


namespace nilnul._time.date_
{
	/// <summary>
	/// the date in present scope, the context or environment
	/// 
	/// </summary>
	static public class _LunisolarX
	{


		/// <summary>
		/// if 润 month doesnot exits, or if day exceeds the month, xpn is thrown;
		/// </summary>
		/// <remarks>
		/// check the input to ensure its validity;
		/// </remarks>
		/// <param name="lunarDate"></param>
		/// <returns></returns>
		static public void Vow(
			int year, bool leap, int month, int day
		)
		{
			var cal = nilnul._time._date.calendar_._ChineseLunisolarX.Calendar;

			/// determines the month
			///
			if (leap)
			{

				var leapMonth = C.GetLeapableMonth(year);

				if (leapMonth == month)
				{
					/// ok
				}
				else
				{
					throw new ArgumentException($"leapMonth is {leapMonth}, not {leap}");
				}
			}

			/// determines day:
			///

			var days = cal.GetDaysInMonth(year, month);

			if (day > days)
			{
				throw new ArgumentOutOfRangeException($"Days in month ({days}) is less than {days}");

			}
		}

		/// <summary>
		/// snap to the nearest possible
		/// 
		/// </summary>
		/// <remarks>
		/// if 润 month doesnot exits, the non润 month is used;
		/// if day exceeds the month, the last day of that month is used;
		/// </remarks>
		/// <param name="lunarDate"></param>
		/// <returns></returns>
		static public (int year, bool leap, int month, int day) SnapToNearest(
			int year, bool leap, int month, int day
		)
		{
			/// determines the month
			///
			if (leap)
			{

				var leapMonth = C.GetLeapableMonth(year);

				if (leapMonth == month)
				{
					/// ok
				}
				else
				{
					leap = false;
				}
			}

			/// determines day:
			///

			var days = nilnul._time._date.calendar_._ChineseLunisolarX.Calendar.GetDaysInMonth(year, month);

			if (day > days)
			{
				day = days;
			}

			return (year,leap,month,day);



		}

		static public (int year, bool leap, int month, int day) SnapToNearest(
			(int year, bool leap, int month, int day) intended
		)
		{
	

			return SnapToNearest(intended.year,intended.leap,intended.month,intended.day);



		}
		public static (int year, bool leap, int month, int day) ToChineseDate(this DateTime datetime)
		{


			int cYear = C.Calendar.GetYear(datetime);
			int cMonth = C.Calendar.GetMonth(datetime);
			int cDay = C.Calendar.GetDayOfMonth(datetime);

			//获取闰月， 0 则表示没有闰月
			int leapMonth = C.Calendar.GetLeapMonth(cYear);

			if (leapMonth == 0)
			{

				return (cYear, false, cMonth, cDay);

			}
			else
			{

				if (cMonth < leapMonth)
				{
					return (cYear, false, cMonth, cDay);

				}
				else if (cMonth == leapMonth)
				{

					return (cYear, true, cMonth - 1, cDay);

				}
				else
				{
					return (cYear, false, cMonth - 1, cDay);
				}



			}




			//return (cYear, leapMonth == cMonth, cMonth, cDay);
		}

		public static DateTime ToGregorian(int year, bool leap, int month, int day)
		{

			int leapMonth = C.Calendar.GetLeapMonth(year);



			if (leapMonth != 0)
			{
				int monthLeapable = leapMonth - 1;

				if (month < monthLeapable)
				{
					if (leap)
					{
						throw new ArgumentOutOfRangeException(string.Format("Leap month of the year is: {0}", monthLeapable));
					}

				}
				else

				if (month == monthLeapable)
				{
					if (leap)
					{
						month++;
					}


				}
				else
				{
					if (leap)
					{
						throw new ArgumentOutOfRangeException(string.Format("Leap month of the year is: {0}", monthLeapable));

					}
					else
					{
						month++;
					}

				}

			}
			else
			{
				if (leap)
				{
					throw new ArgumentOutOfRangeException("No leap month in this year.");
				}
			}



			return new DateTime(year, month, day, C.Calendar);
		}

		public static DateTime ToGregorian(int year,  int month, int day)
		{
			return ToGregorian(year,false,month,day);
		}

		public static DateTime ToGregorian((int year, bool leap, int month, int day) lunisolarDate)
		{
			return ToGregorian(lunisolarDate.year,lunisolarDate.leap,lunisolarDate.month,lunisolarDate.day);
		}
		public static DateTime ToGregorian((int year,  int month, int day) lunisolarDate)
		{
			return ToGregorian(lunisolarDate.year,false,lunisolarDate.month,lunisolarDate.day);
		}


		static public (int year, bool leap, int month, int day) Today()
		{
			return ToChineseDate(DateTime.Now);
		}



		public static (int year, bool leap, int month) GetYearMonth(this DateTime datetime)
		{


			int cYear = C.Calendar.GetYear(datetime);
			int cMonth = C.Calendar.GetMonth(datetime);

			//获取闰月， 0 则表示没有闰月
			int leapMonth = C.Calendar.GetLeapMonth(cYear);

			if (leapMonth == 0)
			{

				return (cYear, false, cMonth);

			}
			else
			{

				if (cMonth < leapMonth)
				{
					return (cYear, false, cMonth);

				}
				else if (cMonth == leapMonth)
				{

					return (cYear, true, cMonth - 1);

				}
				else
				{
					return (cYear, false, cMonth - 1);
				}

			}

		}

		static public (int year, bool leap, int month) GetYearMonth() {
			return GetYearMonth(DateTime.Now);
		}


		static public int  GetYear() {
			return C.Calendar.GetYear(DateTime.Now);
		}

	}
}
