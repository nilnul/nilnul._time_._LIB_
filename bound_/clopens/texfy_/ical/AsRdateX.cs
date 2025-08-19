using nilnul.time.bound_.clopen.texfy_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time.bound_.clopens.texfy_.ical
{
	static public  class _AsRdateX
	{
		public const string PREFIX = "RDATE;VALUE=PERIOD:";


		/// <summary>
		/// useful in google calendar to append a new period to the inherent period
		/// </summary>
		/// <param name="start"></param>
		/// <param name="end"></param>
		/// <returns></returns>
		static public string AsRdate(DateTime start, DateTime end) {

			return $"{PREFIX}{_IcalX._Phrase_1gt(start,end)}";

		}

		static public string _AsRdate_0started(IEnumerable<( DateTime start, DateTime end) > clopens) {

			return $"{PREFIX}{
				nilnul.objs._PhraseX._Phrase(clopens.Select(
					x=>_IcalX._Phrase_0clopen(x)
				))
			}";

		}

	}
}
