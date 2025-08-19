using nilnul.time.seq_.ical_._rfc.clauz_._rrule.part_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time.seq_.ical_._rfc.clauz_.rrule_.weekly._lex.texfy_
{
	static public class _ShanghaiX
	{
		static public string _Texfy_0til(

			DateTime tilInclusive
		)
		{
			return _TexfyX._Texfy_0til(
				
				nilnul.time_.zoned_._ShanghaiX.ToShanghai(
					tilInclusive
				)
			);
		}

		static public string _Texfy_0interval_1til(
			int interval
			,
			DateTime tilInclusive
		)
		{
			return _TexfyX._Texfy_0interval_1til(
				interval,
				
				nilnul.time_.zoned_._ShanghaiX.ToShanghai(
					tilInclusive
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
			DateTime tilInclusive
		)
		{
			return _TexfyX._Texfy_0diems_1interval_2til(
				dayOfWeeks,
				interval
				,
				nilnul.time_.zoned_._ShanghaiX.ToShanghai(
					tilInclusive
				)
			);
		}

		static public string _Texfy_0diems_1intervalPlural_2til(

			IEnumerable<DayOfWeek> dayOfWeeks
			,
			int interval
			,
			DateTime tilInclusive
		)
		{

			return _TexfyX._Texfy_0diems_1interval8plural_2til(
				dayOfWeeks,
				interval
				,
				nilnul.time_.zoned_._ShanghaiX.ToShanghai(
					tilInclusive
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
			DateTime tilInclusive
		)
		{

			return _TexfyX._Texfy_0diems_1til(
				dayOfWeeks
			
				,
				nilnul.time_.zoned_._ShanghaiX.ToShanghai(
					tilInclusive
				)
			);

		}




	}
}