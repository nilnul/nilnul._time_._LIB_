using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Diagnostics;

namespace nilnul._time.date_._calendared.calendar_
{
	static public class CnLunarX
	{
		static ChineseLunisolarCalendar cCalendar = new ChineseLunisolarCalendar();

		/// <summary>
		/// The Chinese DateTime, with "Run" inserted.
		/// </summary>
		/// <param name="datetime"></param>
		/// <returns></returns>
		public static string ToChineseDateString(this DateTime datetime)
		{


			int cYear = cCalendar.GetYear(datetime);
			int cMonth = cCalendar.GetMonth(datetime);
			int cDay = cCalendar.GetDayOfMonth(datetime);

			//获取闰月， 0 则表示没有闰月
			int leapMonth = cCalendar.GetLeapMonth(cYear);


			string month;

			if (leapMonth == 0)
			{
				month = cMonth.ToString();

			}
			else
			{

				if (cMonth < leapMonth)
				{
					month = cMonth.ToString();

				}
				else if (cMonth == leapMonth)
				{

					month = "闰" + (cMonth - 1);

				}
				else
				{
					month = (cMonth - 1).ToString();
				}



			}



			return string.Concat(cYear, ".", month, ".", cDay);
		}


		public static string ToChineseDateString(int year, int month, int day)
		{

			return ToChineseDateString(new DateTime(year, month, day));

		}

		public static string ToChineseDateString()
		{
			return ToChineseDateString(DateTime.Now);
		}

		static void Main(string[] args)
		{
			//Console.WriteLine(GetLeapMonth()); 

			Debug.WriteLine(GetLeapMonth());

			Debug.WriteLine(ChineseToGregorian(2012, 5,false ,5));

			Debug.WriteLine(ToChineseDateString(2012,5, 23));




		}



		static public string GetChineseYearEndString()
		{
			return GetChineseYearEnd().ToString("yyyy-M-d");

		}

		/// <summary>
		/// for current year.
		/// </summary>
		/// <returns></returns>
		static public DateTime GetChineseYearEnd()
		{




			return GetChineseYearEnd(DateTime.Now);



		}


		static public DateTime GetChineseYearEnd(DateTime datetime)
		{




			int cYear = cCalendar.GetYear(datetime);

			int months = cCalendar.GetMonthsInYear(cYear);

			var days = cCalendar.GetDaysInMonth(cYear, months);


			return new DateTime(cYear, months, days, cCalendar);



		}


		/// <summary>
		/// note: if 4 returned, that means the 4th month is Month of Run #3.
		/// </summary>
		/// <returns></returns>
		static public int GetLeapMonth()
		{

			var l = cCalendar.GetLeapMonth(DateTime.Now.Year);
			if (l == 0)
			{
				return l;

			}
			else
			{
				return l - 1;
			}
		}

		/// <summary>
		/// 2009 Leap 6
		/// </summary>
		/// <param name="chineseYear"></param>
		/// <returns></returns>
		static public int GetLeapMonth(int chineseYear)
		{
			return cCalendar.GetLeapMonth(chineseYear);
		}



		static public DateTime ChineseToGregorian(int year, Tuple<int, bool> monthLeaped, int day)
		{

			int leapMonth = cCalendar.GetLeapMonth(year);

			int month = monthLeaped.Item1;




				if (leapMonth != 0)
				{
					if (month<leapMonth-1)
					{
						if (monthLeaped.Item2)
						{
							throw new Exception(string.Format("Leap month of the year is: {0}",leapMonth-1));
						}
						
					}else

					if (month == leapMonth-1)
					
					{
						if (monthLeaped.Item2) { 
							month++;
						}
						

					}
					else 
					{
						if (monthLeaped.Item2)
						{
							throw new Exception(string.Format("Leap month of the year is: {0}",leapMonth-1));

						}
						else
						{
							month++;
						}

					}

				}
				else
				{
					if (monthLeaped.Item2)
					{
						throw new Exception("No leap month in this year.");
					}
				}

			

			return new DateTime(year, month, day, cCalendar);

		}

		static public DateTime ChineseToGregorian(int year, int month, bool leaped, int day)
		{

			return ChineseToGregorian(year, new Tuple<int, bool>(month, leaped), day);

		}

		static public DateTime ChineseToGregorian(int year, int month, int day)
		{

			return ChineseToGregorian(year, new Tuple<int, bool>(month, false), day);

		}


	}
}
