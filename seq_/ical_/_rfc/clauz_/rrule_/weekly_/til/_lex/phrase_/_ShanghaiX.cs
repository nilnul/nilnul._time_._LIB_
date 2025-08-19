using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time.seq_.ical_._rfc.clauz_.rrule_.weekly_.til._lex.phrase_
{
	static public class _ShanghaiX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="localTime">shanghai local time as the last inclusive time</param>
		/// <param name="days"></param>
		/// <returns></returns>
		static public string _Phrase_1til_2interval(
			IEnumerable<DayOfWeek> dayOfWeeks
			,
			DateTime tilInclusive
			,
			int interval = 1
		)
		{
			return _PhraseX._Phrase_0diems_1til_2interval(
				dayOfWeeks
				,
				nilnul.time_.zoned_._ShanghaiX.ToShanghai(
					tilInclusive
				)
				,interval
			);
		}

	

	}
}