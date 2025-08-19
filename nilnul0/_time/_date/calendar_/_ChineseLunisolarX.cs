using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Diagnostics;
using nilnul._time._date.calendar_._lunar;
using D = (int year, bool leap, int month, int day);

namespace nilnul._time._date.calendar_
{

	///发信人: gjq (!@#$%^&*()), 信区: Programming
	///发信站: 水木社区 (Mon Nov 20 03:18:43 2023)
	///首先要找到地球公转周期（回归年，365.2421990741日）和月球公转周期（月球两次合朔平均间隔是29.530588天）。然后就是怎么加闰月的问题，这个有一定规矩，但是似乎也有一些余地（早一个月还是晚一个月加闰）。
	/*
发信人: Juanercc(招招舟子), 信区: Programming
标  题: Re: 公历转农历怎么个计算方法？
发信站: 水木社区(Mon Nov 20 05:58:40 2023), 站内
  
19年和公历重合一次

准备19年的表就行了

	--这个只是近似方法 by: 发信人: wormvirus (迷途小书童)


	阳历（格里高利历）是算术历，所有的日期都是根据公式计算的
  
农历是天文事件历，根据观察到的天文事件来定日期的



	天、月、年，都是整数数字。这跟自然规律对不上。因为月球、地球的自转、公转，都不是整数天，而是无限不循环小数。
用公式是不可能计算出公历的，因为所有的计算都是近似法。只要把时间拉得足够长，都要依靠置闰等人工干预的方法强行对应。
为什么农历看上去误差更大？因为农历是一个更完备的历法，既要考虑月地关系，又要考虑日地关系，还要都转换成整数表达。
即使是纯粹的阴历，误差也更大，因为月相变化周期是29.53059天，它和整数的误差关系是0.5。因为我们考察的单位是年，所以这个误差要乘以12。
地球公转周期是365日6时9分10秒，以年为衡量标准，本身的误差比例就小。


每年推算和发布下一年的
古代观测条件有限，只有冬至（和夏至）的时刻可以定得比较准，所以以其作为参考基准,其他节气都是用两个冬至之间的时间二十四等分

	只不过现代技术发展了，可以预测更远了

紫金山应该已经发布到2100年的了，查就行了

	天文上最重要有四个点:春秋分,冬夏至
  
分别表示昼夜平分,白天最短,白天最长
  
冬夏至同时也是地球轨道的近日点和远日点
  
然后再推出了其他20个节气
  
你看,农历多么的科学


农历包括阴阳历，其中阴历跟着月亮走，决定月份和日期（每月十五月圆），阳历跟着太阳走，决定二十四节气

相对于格里高利历只考虑了太阳运动,农历考虑了both太阳和月亮的运动；为了太阳年加了闰月的就已经阴阳合历了

	气候相对于地球在公转轨道上的移动具有滞后性，大约一个月左右, 农历新年 比 公历 晚有一个月

	公历可以保证无天文校正下千年内夏至只差一天，农历没天文台撑着则置闰很难准确。

	 */
	///一个朔望月为一个月，约29.53天.全年一般是354天或355;，
	///阴历一个月为二十九日或三十日
	/// 当该月是29天时，它被称为小月。当该月是30天时，它被称为大月。
	/// 闰月可以是小月（29天），也可以是大月（30天）；闰月的加入，是为了让农历年与太阳年（即回归年）对齐，防止季节的偏移。
	/// <summary>
	/// 
	/// </summary>
	static public class _ChineseLunisolarX
	{
		static public readonly ChineseLunisolarCalendar Calendar = new ChineseLunisolarCalendar();

		/// <summary>
		/// The Chinese DateTime, with "润" inserted.
		/// </summary>
		/// <param name="datetime"></param>
		/// <returns></returns>
		public static string ToChineseDateString(this DateTime datetime)
		{


			int cYear = Calendar.GetYear(datetime);
			int cMonth = Calendar.GetMonth(datetime);
			int cDay = Calendar.GetDayOfMonth(datetime);

			//获取闰月， 0 则表示没有闰月
			int leapMonth = Calendar.GetLeapMonth(cYear);


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

		[Obsolete(nameof(date_._LunisolarX.ToChineseDate))]
		public static (int year,bool leap, int month,  int day) ToChineseDate(this DateTime datetime)
		{
			return date_._LunisolarX.ToChineseDate(datetime);

			int cYear = Calendar.GetYear(datetime);
			int cMonth = Calendar.GetMonth(datetime);
			int cDay = Calendar.GetDayOfMonth(datetime);

			//获取闰月， 0 则表示没有闰月
			int leapMonth = Calendar.GetLeapMonth(cYear);

			if (leapMonth == 0)
			{

				return (cYear,false, cMonth,  cDay);

			}
			else
			{

				if (cMonth < leapMonth)
				{
					return (cYear,false, cMonth,  cDay);

				}
				else if (cMonth == leapMonth)
				{

					return (cYear,true, cMonth-1,  cDay);

				}
				else
				{
					return (cYear,false, cMonth-1,  cDay);
				}



			}




			return (cYear,leapMonth ==cMonth, cMonth,  cDay);
		}

		public static string ToChineseDateString(int year, int month, int day)
		{

			return ToChineseDateString(new DateTime(year, month, day));

		}

		public static string ToChineseDateString()
		{
			return ToChineseDateString(DateTime.Now);
		}

		//static void Main(string[] args)
		//{
		//	//Console.WriteLine(GetLeapMonth()); 

		//	Debug.WriteLine(GetLeapMonth());

		//	Debug.WriteLine(ChineseToGregorian(2012, 5, false, 5));

		//	Debug.WriteLine(ToChineseDateString(2012, 5, 23));

		//}



		static public string GetChineseYearEndString()
		{
			return GetChineseYearEnd().ToString("yyyy-M-d");

		}

		/// 农历的闰年因为有闰月的存在一般是385天，而平年则有354或355天
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




			int cYear = Calendar.GetYear(datetime);

			int months = Calendar.GetMonthsInYear(cYear);

			var days = Calendar.GetDaysInMonth(cYear, months);


			return new DateTime(cYear, months, days, Calendar);



		}


		/// <summary>
		/// note: if 4 returned, that means the 4th month is Month of Run(润) #3.
		/// </summary>
		/// <returns></returns>
		static public int GetLeapableMonth()
		{
			return GetLeapableMonth(DateTime.Now.Year);
		}

		[Obsolete(nameof(GetLeapableMonth) + " is preferred to avoid ambiguity with " + nameof(ChineseLunisolarCalendar.GetLeapMonth))]
		static public int GetLeapMonth()
		{
			return GetLeapableMonth();
			
		}


		/// <summary>
		/// can have leap months after any month of the year;
		/// 阴阳历若采十九年七闰法，每19年加入7个闰月
		/// ;eg:
		/// 2009 Leap 6
		/// </summary>
		/// <param name="chineseYear"></param>
		/// <returns>
		/// 0 if there is no leapable month
		/// </returns>
		static public int GetLeapableMonth(int chineseYear)
		{
			var l = Calendar.GetLeapMonth(chineseYear);
			if (l == 0)
			{
				return l;

			}
			else
			{
				return l - 1;
			}

		}

		[Obsolete(nameof(GetLeapableMonth) + " is preferred to avoid ambiguity with " + nameof(ChineseLunisolarCalendar.GetLeapMonth))]
		static public int GetLeapMonth(int chineseYear)
		{
			return GetLeapableMonth(chineseYear);

		}



		static public DateTime ChineseToGregorian(int year, Tuple<int, bool> monthLeaped, int day)
		{
			return ChineseToGregorian(
				year,monthLeaped.Item2,monthLeaped.Item1,day
			);
		}
		public static DateTime ChineseToGregorian(int year, bool leap, int month, int day)
		{
			return date_._LunisolarX.ToGregorian(year, leap, month, day);

			int leapMonth = Calendar.GetLeapMonth(year);



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



			return new DateTime(year, month, day, Calendar);
		}

		static public DateTime ChineseToGregorian(int year, int month, bool leaped, int day)
		{

			return ChineseToGregorian(year, new Tuple<int, bool>(month, leaped), day);

		}

		static public DateTime ChineseToGregorian(int year, int month, int day)
		{

			return ChineseToGregorian(year, new Tuple<int, bool>(month, false), day);

		}

		public static DateTime ChineseToGregorian(
			D date8lunisolar
		)
		{
			return ChineseToGregorian(date8lunisolar.year,date8lunisolar.leap,date8lunisolar.month,date8lunisolar.day);
		}
	}
}
