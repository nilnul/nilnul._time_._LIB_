using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._time.date
{
	static public class _ParseX
	{

		public const string ShortYear = @"\d\d";
		public const string LongYear = @"\d\d"+ShortYear;
		public const string Month = @"0?[1-9]|10|12";
		public const string Day = @"(0?[1-9])|(1|2)\d|30|31";

		public static string SepedWithYearShort(char? sep=null) {
			return $@"(?<year>{ShortYear}){sep}(?<month>{Month}){sep}(?<day>{Day})";
		}

		public static string SepedByDotWithYearShort() {
			return SepedWithYearShort('.');
		}

		public static string SepedWithYearLong(char? sep=null) {
			return $@"(?<year>{LongYear}){sep}(?<month>{Month}){sep}(?<day>{Day})";
		}

		public static string SepedByDotWithYearLong() {
			return SepedWithYearLong('.');
		}



	}
}
