using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time.seq_.ical_._rfc.clauz_.rrule_.weekly_.til._lex
{
	static public class _PhraseX
	{
		public const string FREQ = "WEEKLY";

		static public readonly string Freq = _rrule.part_._FreqX.Texfy(FREQ);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="tilInclusive">inclusive time</param>
		/// <param name="days"></param>
		/// <returns></returns>
		static public string _Phrase_0diems_1til_2interval(

			IEnumerable<DayOfWeek> dayOfWeeks
			,
			DateTimeOffset tilInclusive
			,
			int interval = 1
		) {

			var t= _RruleX.OfTgt(string.Join(";"
				,
				[
					Freq
					,
					$"BYDAY={
						string.Join(
							","
							,
							dayOfWeeks.Select(
								d => d.ToString().Substring(0, 2).ToUpperInvariant()
							)
						)
					}"
					,
					rfc._phrase._TilX.AsPart(tilInclusive)
				]
			));

			if (interval ==1)
			{
				return t;
			}

			return string.Join(
				";"
				,t
				, nilnul.obj.attr._PhraseX.Phrase( "INTERVAL",interval)
			);

		}

		static public string _Phrase_0diems_1til_2interval(

			IEnumerable<DayOfWeek> dayOfWeeks
			,
			DateTime tilInclusive
			,
			int interval = 1
		) {

			var t= _RruleX.OfTgt(string.Join(";"
				,
				[
					Freq
					,
					$"BYDAY={
						string.Join(
							","
							,
							dayOfWeeks.Select(
								d => d.ToString().Substring(0, 2).ToUpperInvariant()
							)
						)
					}"
					,
					rfc._phrase._TilX.AsPart(tilInclusive)
				]
			));

			if (interval ==1)
			{
				return t;
			}

			return string.Join(
				";"
				,t
				, nilnul.obj.attr._PhraseX.Phrase( "INTERVAL",interval)
			);

		}

		static public string _Phrase_0diems_1dateAsTil8current_2interval(

			IEnumerable<DayOfWeek> dayOfWeeks
			,
			DateTime tilInclusive
			,
			int interval = 1
		) {

			var t= _RruleX.OfTgt( string.Join(";"
				,
				[
					Freq
					,
					$"BYDAY={
						string.Join(
							","
							,
							dayOfWeeks.Select(
								d => d.ToString().Substring(0, 2).ToUpperInvariant()
							)
						)
					}"
					,

					nilnul.time.seq_.ical_._rfc.clauz_._rrule.part_._UntilX.AsPart_0date(tilInclusive)
				]
			));

			if (interval ==1)
			{
				return t;
			}

			return string.Join(
				";"
				,t
				, nilnul.obj.attr._PhraseX.Phrase( "INTERVAL",interval)
			);

		}

	}
}
