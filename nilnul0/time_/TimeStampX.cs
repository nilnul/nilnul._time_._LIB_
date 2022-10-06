using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace nilnul.time
{
	static public class TimeStampX
	{

		static public string RegexStr=@"\d{18}";
		public static Regex Regex=new Regex(@"^\d{18}$");

		public static String GetTimestamp()
		{
			return GetTimestamp(DateTime.Now);
		}
		public static String GetTimestampUtc()
		{
			return GetTimestamp(DateTime.UtcNow);
		}

		public static String GetTimestamp(this DateTime value)
		{
			return value.ToString("yyyyMMddHHmmssffff");
		}
	}
}
