using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time.name_
{
	public static  class _YearMonth
	{
		static public string ToChineseYearMonth( this DateTime time) {
			return $"{time.Year}年{time.Month}月";
		}
	}
}
