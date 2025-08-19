using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time.seq_.ical_._rfc.clauz_.rrule_
{

	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		annually
	internal class _YearlyX
	{
		/// eg:
		/// $"RRULE:FREQ=YEARLY;BYMONTH=5;BYDAY=TH;WKST=MO;BYMONTHDAY=5,6,7,8,9,10,11"

	}

	public class Yearly
	{
		public const string FREQ = "YEARLY";

		public int[] byMonthDay = null;
		public int[] byMonth = null;
		public int? interval = null;


		public Yearly(
			int? interval, int[] byMonth, int[] byMonthDay
		)
		{
			this.interval = interval;
			this.byMonth = byMonth;
			this.byMonthDay = byMonthDay;
		}

		public Yearly(
			 int[] byMonth, int[] byMonthDay

		):this(null,byMonth,byMonthDay)
		{
		}

		public override string ToString()
		{
			return nilnul.obj.duo.Phrase.Unison.phrase(
				_RruleX.KEY
				,
				string.Join(
					";"
					,
					parts()
				)
			);
		}

		public IEnumerable<string> parts() {

			yield return clauz_._rrule.part_._FreqX.Texfy(FREQ);

			if (interval is not null)
			{
				yield return nilnul.obj.attr._PhraseX.Phrase(
					_rrule.part_._IntervalX.KEY
					,
					interval.Value
				);
			}

			if (byMonth.Length >0)
			{
				yield return nilnul.obj.attr._PhraseX.Phrase(
					_rrule.part_._ByMonthX.KEY
					,
					string.Join(",",this.byMonth)
				);
			}

			if (byMonthDay.Length >0)
			{
				yield return nilnul.obj.attr._PhraseX.Phrase(
					_rrule.part_._ByMonthDayX.KEY
					,
					string.Join(",",this.byMonthDay)
				);
			}

		}

	}
}
