using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time.seq_.recur_.monthly.lex_._rfc
{
	static public class _PhraseX
	{
		static public string _Phrase_0days(
			params int[] days
		) {
			return $"RRULE:FREQ=MONTHLY;BYMONTHDAY={string.Join(",", days)}";
		}
	}
}
