using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time.phrase_.full_
{
	/// <summary>
	/// 
	/// </summary>
	///
	[Obsolete()]
	public class SplitSecond
		:
		nilnul.time_.datetime.PhraseA
	{
		/// <summary>
		/// 
		/// </summary>
		/// <remarks>
		/// eg:
		///		S
		///			ending of second, begining split second. this acts as a decimal point
		/// </remarks>
		public const char SPLITTER = 'S';

		/// <summary>
		/// 
		/// </summary>
		/// <param name="obj"></param>
		/// <returns>
		/// eg:
		///		210702145300S00125
		/// </returns>
		public override string phrase(DateTime obj/*=DateTime.UtcNow*/)
		{
			var ticks=obj.ToString(Full.Format4Ticks);

			var ticksTrimmed=ticks.TrimEnd('0');

			var date = obj.ToString(nilnul.time_.datetime.phrase_.Yy2ss.FORMAT4YYMMDDHHMMSS);

			
			if (ticksTrimmed == string.Empty)
			{
				return date;//remove trailing nils in hourMinutSecond; note the nil in "10" is not removable. the date can also be trimed (of day 01,month 01, as day or month is one-based)
			}

			return $"{date}{SPLITTER}{ticksTrimmed}";	//point is not allowed, so we use "_". or we can use "S".
		}

		

		static public SplitSecond Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<SplitSecond>.Instance;
			}
		}

	}
}
