using System;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.time.seq_.ical_._rfc.clauz_._rrule.part_
{
	static public class _ByDayX
	{
		public const string KEY = "BYDAY";


		static public string _Texfy_0diems(
			IEnumerable<DayOfWeek> dayOfWeeks
		)
		{

			return nilnul.obj.attr._PhraseX.Phrase(
				KEY
				,
				nilnul.objs._PhraseX._Phrase(
					dayOfWeeks.Select(
						d => d.ToString().Substring(0, 2).ToUpperInvariant()
					)
				)
			);

		}

	}
}
