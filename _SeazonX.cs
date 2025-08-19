using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time
{
	/// <summary>
	/// for north hemisphere
	/// </summary>
	/// <see cref="nilnul._time.date."/>
	static public class _Season4NorthX
	{
		/// learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/patterns#parenthesized-pattern
		///	,where there is an example of season
		/// <summary>
		/// 
		/// </summary>
		/// <param name="month"></param>
		/// <returns></returns>
		public static _season.Li_ _Season_0month(int month) => month switch
		{
			1 or 2 or 12 => _season.Li_.Winter,
			> 2 and < 6 =>  _season.Li_.Spring,
			> 5 and < 9 =>  _season.Li_.Summer,
			> 8 and < 12 => _season.Li_.Autumn,
		};
		public static _season.Li_ Season(DateTime time) => _Season_0month(time.Month);


	}
}
