using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._time._date.calendar_
{
	/// after pre_Juian calendar, the Julia calendar is used.
	/// the predecessor to this is: Julian Calendar,proposed by Roman consul Julius Caesar in 46 BC
	/// 儒略历的问题是在于认为一年是365.25天,所以每四年一闰(没有正百年400整除闰年的说法).这个累积2k+年,就导致春分点移动了10天
	/// 格里高利历认为是365.2425天,其实也与真是周期不一致,差一点;公历的月并不对应月亮而是固定的
	/// 节气是公历,是太阳运行规律的体现; 
	/// <summary>
	/// the Gregorian calendar is used in most parts of the world.
	/// </summary>
	/// <remarks>
	/// named after  Pope Gregory XIII to make the average calendar year 365.2425 days long, more closely approximating the 365.2422-day 'tropical' or 'solar' year that is determined by the Earth's revolution around the Sun.
	/// We have leap years. the month's leap is derived from year's leap;
	/// </remarks>
	/// alias:
	///		日历
	///		
	internal class IGregory
	{
	}
}
