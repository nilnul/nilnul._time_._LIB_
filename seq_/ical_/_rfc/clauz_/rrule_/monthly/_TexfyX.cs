using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time.seq_.ical_._rfc.clauz_.rrule_.monthly
{
	static public class _TexfyX
	{
		public const string FREQ_KEY = "MONTHLY";

		/// <summary>
		/// an attr
		/// </summary>
		static public readonly string Freq = _rrule.part_._FreqX.Texfy(FREQ_KEY);

		static public string Texfy(

		) {

			return _RruleX.OfTgt(

				//nilnul.obj.tags._TexfyX._Texfy_pars8tags(
					Freq
				//)
			);


		}

		static public string _Texfy_0count(
			int count=1
		) {

			return _RruleX.OfTgt(

				nilnul.obj.tags._TexfyX._Texfy_pars8tags(
					Freq
					,
					_rrule.part_._CountX._Texfy_0count(count)
				)
			);
		}


		static public string _Texfy_0interval(
			int interval=1
		) {

			return _RruleX.OfTgt(

				nilnul.obj.tags._TexfyX._Texfy_pars8tags(
					Freq
					,
					_rrule.part_._IntervalX._Texfy_0interval(interval)
				)
			);
		}

		static public string _Texfy_0interval_1count(
			int interval=1
			,
			int count =1
		) {

			return _RruleX.OfTgt(

				nilnul.obj.tags._TexfyX._Texfy_pars8tags(
					Freq
					,
					_rrule.part_._IntervalX._Texfy_0interval(interval)
					,
					_rrule.part_._CountX._Texfy_0count(count)
				)
			);
		}


		static public string _Texfy_0interval_1til(
			int interval
			,
			DateTimeOffset tilInclusive
		) {

			return _RruleX.OfTgt(

				nilnul.obj.tags._TexfyX._Texfy_pars8tags(
					Freq
					,
					_rrule.part_._IntervalX._Texfy_0interval(interval)
					,
					_rrule.part_._UntilX.AsPart(tilInclusive)
				)
			);
		}
	

		static public string _Texfy_0til(
			DateTimeOffset tilInclusive
		) {

			return _RruleX.OfTgt(

				nilnul.obj.tags._TexfyX._Texfy_pars8tags(
					Freq
					,
					_rrule.part_._UntilX.AsPart(tilInclusive)
				)
			);
		}



	}
}
