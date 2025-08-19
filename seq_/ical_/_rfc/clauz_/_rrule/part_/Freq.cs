using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time.seq_.ical_._rfc.clauz_._rrule.part_
{
	/// <summary>
	///  The FREQ rule part is REQUIRED, but MUST NOT occur more than once.
	/// </summary>
	/// 
	public enum Freq
	{
		SECONDLY,
		MINUTELY,
		HOURLY
			,
		/// <summary>
		/// Daily
		/// </summary>
		DAILY,
		WEEKLY,
		/// <summary>
		/// need to capitalize;
		/// </summary>

		MONTHLY,
		YEARLY




	}

	static public class _FreqX
	{
		static public string KEY = "FREQ";
		static public string Texfy(string freq) {
			return nilnul.obj.attr._PhraseX.Phrase(
				KEY
				,
				freq
			);
		}
		static public string Texfy(Freq freq) {
			return Texfy(
				freq.ToString().ToUpperInvariant()
			);
		}


	}
}
