using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time.seq_.recur_.monthly_.til.lex_._rfc.phrase_
{
	static public class _ShanghaiX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="localTime">shanghai local time as the last inclusive time</param>
		/// <param name="days"></param>
		/// <returns></returns>
		static public string _Phrase_0til_1days(
			DateTime localTime,

			params int[] days
		) {
			return _PhraseX._Phrase_0til_1days(
				new DateTimeOffset(
					localTime, nilnul.time_._zoned.zone_._ShanghaiX.Timespan
				)
				,days
			);
		}
	}
}