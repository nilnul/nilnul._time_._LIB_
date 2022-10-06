using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time.length_.span.phrase_.verable_
{
	/// <summary>
	/// nonpreferable, as how to paraphrase the trailing number  is unclear.
	/// </summary>
	/// <remarks>
	/// no punc but "_", using only letters and underscores such as to be used in ver.
	///
	/// </remarks>
	public class MidNotation4SecondsSub_assumeNonneg
		: nilnul.obj.PhraseI<TimeSpan>
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="obj"></param>
		/// <returns></returns>
		public string phrase(TimeSpan obj)
		{



			return obj.Days == 0 ? "" : $"{obj.Days}d"
				+
				(obj.Hours == 0 ? "" : $"{obj.Hours}h")
				+
				(obj.Minutes == 0 ? "" : $"{obj.Minutes}i")

				+
				length_.seconds1milli.phrase_._VerableX.Phrase_assumeNonnegs(obj.Seconds,obj.Milliseconds)


				;

		}


		static public MidNotation4SecondsSub_assumeNonneg Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<MidNotation4SecondsSub_assumeNonneg>.Instance;
			}
		}

	}
}
