using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time.seq_.ical_._rfc.clauz_.rrule_.weekly._lex
{
	static public class _TexfyX
	{
		public const string FREQ_KEY = "WEEKLY";

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

		/// <summary>
		/// 
		/// </summary>
		/// <param name="tilInclusive">inclusive time</param>
		/// <param name="days"></param>
		/// <returns></returns>
		static public string _Texfy_0diems_1interval_2til(

			IEnumerable<DayOfWeek> dayOfWeeks
			,
			int interval 
			,
			DateTimeOffset tilInclusive
		)
		{
			if (interval == 1)
			{
				return _Texfy_0diems_1til(dayOfWeeks, tilInclusive);
			}

			return _Texfy_0diems_1interval8plural_2til(dayOfWeeks,interval,tilInclusive) ;

		}

		static public string _Texfy_0diems_1interval8plural_2count(

			IEnumerable<DayOfWeek> dayOfWeeks
			,
			int interval
			,
			int count
		)
		{

			return _RruleX.OfTgt(
				nilnul.obj.props._PhraseX.Phrase(
					Freq
					,
					_rrule.part_._ByDayX._Texfy_0diems(dayOfWeeks)
					,
					_rrule.part_._IntervalX._Texfy_0interval(interval)
					,
					_rfc.clauz_._rrule.part_._CountX._Texfy_0count(
					count
					)
				)
			);

		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public string _Texfy_0diems_1count(

			IEnumerable<DayOfWeek> dayOfWeeks
			,
			int count
		)
		{

			return _RruleX.OfTgt(
				nilnul.obj.props._PhraseX.Phrase(
					Freq
					,

					_rrule.part_._ByDayX._Texfy_0diems(dayOfWeeks)
					,
					_rfc.clauz_._rrule.part_._CountX._Texfy_0count(
					count)
				)

			);



		}


		static public string _Texfy_0diems_1interval_2count(

			IEnumerable<DayOfWeek> dayOfWeeks
			,
			int interval 
			,
			int count
		)
		{
			return interval == 1
				? _Texfy_0diems_1count(dayOfWeeks, count)
				: _Texfy_0diems_1interval8plural_2count(dayOfWeeks,interval,count);
		}


		static public string _Texfy_0diems_1interval8plural_2til(

			IEnumerable<DayOfWeek> dayOfWeeks
			,
			int interval 
			,
			DateTimeOffset tilInclusive
		)
		{

			return _RruleX.OfTgt(
				nilnul.obj.tags._TexfyX._Texfy_pars8tags(
					Freq
					,
					_rrule.part_._ByDayX._Texfy_0diems(dayOfWeeks)
					,
					_rrule.part_._IntervalX._Texfy_0interval(interval)
					,
					_rfc.clauz_._rrule.part_._UntilX.AsPart(
					tilInclusive)
				)
			);

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="tilInclusive">inclusive time</param>
		/// <param name="days"></param>
		/// <returns></returns>
		static public string _Texfy_0diems_1til(

			IEnumerable<DayOfWeek> dayOfWeeks
			,
			DateTimeOffset tilInclusive
		)
		{

			return _RruleX.OfTgt(
				nilnul.obj.tags._TexfyX._Texfy_pars8tags(
					Freq
					,

					_rrule.part_._ByDayX._Texfy_0diems(dayOfWeeks)
					,
					_rfc.clauz_._rrule.part_._UntilX.AsPart(
					tilInclusive)
				)
				
			);

		

		}



	}
}
