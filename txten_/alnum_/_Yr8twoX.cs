using System;

namespace nilnul.time.texfy_.alnum_
{
	/// <summary>
	/// <see cref="time.lex_.yy2ss_._word.Phrase"/>
	/// </summary>
	static public class _Yr8twoX
	{
		public const string FORMAT = nilnul._time.date.phrase_.num_.YrInTwo.FORMAT + "T" + _time.clock.texfy_._NumX.FORMAT;

		static public string Phrase(DateTime dateTime) {

			return dateTime.ToString(
				FORMAT
			);
		}
	}


}
