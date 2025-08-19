using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time.seq_.ical_._rfc.clauz_.rrule_.daily._lex
{
	static public class _TexfyX
	{
		public const string FREQ_KEY = "DAILY";

		/// <summary>
		/// an attr
		/// </summary>
		static public readonly string Freq = _rrule.part_._FreqX.Texfy(FREQ_KEY);

		static public string Texfy(

		) {

			return _RruleX.OfTgt(

				//nilnul.obj.props._PhraseX.Phrase(
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

		/// <summary>
		/// <see cref="_rrule.parts_.Count9Interval"/>
		/// </summary>
		/// <param name="count"></param>
		/// <param name="interval"></param>
		/// <param name="tilInclusive"></param>
		/// <returns></returns>
		///
		[Obsolete(nameof(_rrule.parts_.xpn_.ICount9Until),true)]
		static public string _Texfy_0count_1interval_2til(
			int count,
			int interval
			,
			DateTimeOffset tilInclusive
		) {

			return _RruleX.OfTgt(

				nilnul.obj.tags._TexfyX._Texfy_pars8tags(
					Freq
					,
					_rrule.part_._CountX._Texfy_0count(count)
					,
					_rrule.part_._IntervalX._Texfy_0interval(interval)
					,
					_rrule.part_._UntilX.AsPart(tilInclusive)
				)
			);
		}

		[Obsolete(nameof(_rrule.parts_.xpn_.ICount9Until),true)]
		static public string _Texfy_0count_1til(
			int count,
			DateTimeOffset tilInclusive
		) {

			return _RruleX.OfTgt(

				nilnul.obj.tags._TexfyX._Texfy_pars8tags(
					Freq
					,
					_rrule.part_._CountX._Texfy_0count(count)
					,
					_rrule.part_._UntilX.AsPart(tilInclusive)
				)
			);
		}

		[Obsolete(nameof(_rrule.parts_.xpn_.ICount9Until),true)]
		static public string _Texfy_0count_1til(
			int count
			,
			DateTime tilInclusive
		) {

			return _RruleX.OfTgt(

				nilnul.objs.phrase_.Semicolon.Unison.phrase_ofParams(
					Freq
					,
					_rrule.part_._CountX._Texfy_0count(count)
					,
					_rrule.part_._UntilX.AsPart(tilInclusive)
				)
			);
		}


		/*
		[Obsolete("xpn per std")]
		static public string _Texfy_0count_1til(
			int count
			,
			DateTimeOffset tilInclusive
		) {

			return _RruleX.OfParts(

				nilnul.obj.tags._TexfyX._Texfy_pars8tags(
					Freq
					,
					_rrule.part_._CountX._Texfy_0count(count)
					,
					_rrule.part_._UntilX.AsPart(tilInclusive)
				)
			);
		}
		*/

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
