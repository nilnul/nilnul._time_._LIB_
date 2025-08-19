using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time.seq_.ical_._rfc.clauz_.rrule_.daily._lex.texfy_
{
	static public class _ShanghaiX
	{

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
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

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
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

		[Obsolete(nameof(_rrule.parts_.xpn_.ICount9Until),true)]
		static public string _Texfy_0count_1interval_2til(
			int count,
			int interval
			,
			DateTime tilInclusive
		)
		{
			return _TexfyX._Texfy_0count_1interval_2til(
				count,
				interval,
				
				nilnul.time_.zoned_._ShanghaiX.ToShanghai(
					tilInclusive
				)
			);
		}

		[Obsolete(nameof(_TexfyX._Texfy_0interval) + " is preferred as timezone info is not needed")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public string _Texfy_0interval(
			int interval
		)
		{
			return _TexfyX._Texfy_0interval(
				interval
			);
		}

		[Obsolete(nameof(_TexfyX._Texfy_0interval) + " is preferred as timezone info is not needed")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public string _Texfy_0count(
			int count
		)
		{
			return _TexfyX._Texfy_0count(
				count
			);
		}


	


	

	}
}