using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time.length_.span.phrase_.verable_
{
	/// <summary>
	/// no punc but "_", using only letters and underscores such as to be used in ver.
	/// </summary>
	public class SubsecondsAsMantissa
		: nilnul.obj.PhraseI<TimeSpan>
	{
		public string phrase(TimeSpan obj)
		{




			var subseconds = length_.seconds1milli.phrase_.verable_._UnderscoreX.Phrase_assumeNonnegs(obj.Seconds, obj.Milliseconds);


			return (obj.Days == 0 ? "" : $"{obj.Days}d")
				+
				(obj.Hours == 0 ? "" : $"{obj.Hours}h")
				+
				(obj.Minutes == 0 ? "" : $"{obj.Minutes}i")

				+
				(subseconds==string.Empty? "": (subseconds + "s" ))


				;

		}


		static public SubsecondsAsMantissa Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<SubsecondsAsMantissa>.Instance;
			}
		}

	}
}
