using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time.seq_.recur_.monthly_.til.lex_._rfc
{
	static public class _PhraseX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="tilInclusive">inclusive time</param>
		/// <param name="days"></param>
		/// <returns></returns>
		static public string _Phrase_0til_1days(
			DateTimeOffset tilInclusive,

			params int[] days
		) {
			return $"RRULE:FREQ=MONTHLY;{ical_.rfc._phrase._TilX.AsPart(tilInclusive)};BYMONTHDAY={string.Join(",", days)}";
		}

	}
}
