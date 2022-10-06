using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time.phrase_
{
	/*
		/// yy is 2 in width, becuz:
		///		1) in the year end and the begining of next year, we need the 2-digits of year to distinguish the time point around the year end/begin.
		///		2) two-digits is enough to different the auto-generated timestamp.
		///	The problem with 2-digits year is:
		///		1) one person will be around the change of millennium.
		///		2) one perso will live from the start of millennium to its end.
		///		3) 100 years are short for the inneration of computer storage technology.
		///		4) if multiple persons work in the same repo, at different times, they may have different interpretations of the year.
		///	4-digits:
		///		1) too long to write. not short enough in contrast with 2-digits.
		///		2) not the same length as month and day, hour, minute, second.
		///		
		///	conclusion:
		///		we may consider using 4-digits year. 
	 
	 */
	/// <summary>
	/// with reference to <seealso cref="nameof(nilnul.txt_._vered.ver_.ISwitched)"/>, the phrase can be used as part of ver. second is the minimum unit of measure; then we use mantissa/fraction of seconds to denote a split of second
	/// </summary>
	///
	[Obsolete()]
	public class Full
		:
		nilnul.time_.datetime.PhraseA
	{
		public static string Format4Ticks = nilnul.txt.op_.RepeatX.Repeat("f", 7);
		/// <summary>
		/// 
		/// </summary>
		/// <remarks>
		/// eg:
		///		_
		///		S
		/// </remarks>
		public const char SPLITTER = '_';

		/// <summary>
		/// 
		/// </summary>
		/// <param name="obj"></param>
		/// <returns>
		/// eg:
		///		210702145300_00125
		///		210702145300S00125
		/// </returns>
		public override string phrase(DateTime obj)
		{
			var ticks=obj.ToString(Format4Ticks);

			var ticksTrimmed=ticks.TrimEnd('0');

			var date = obj.ToString(nilnul.time_.datetime.phrase_.Yy2ss.FORMAT4YYMMDDHHMMSS);

			
			if (ticksTrimmed == string.Empty)
			{
				return date;//remove trailing nils in hourMinutSecond; note the nil in "10" is not removable. the date can also be trimed (of day 01,month 01, as day or month is one-based)
			}

			return $"{date}{SPLITTER}{ticksTrimmed}";	//point is not allowed, so we use "_". or we can use "".
		}

		

		static public Full Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Full>.Instance;
			}
		}

	}
}
