using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time_._zoned.zone_.span.phrase_
{
	/// <summary>
	/// no punc but "_", using only letters and underscores such as to be used in ver.
	/// </summary>
	public class Verable_subsecondsAsMantissa
		: nilnul.obj.PhraseI<TimeSpan>
	{
		public string phrase(TimeSpan obj)
		{
			var lengthTxt = time.length_.span.phrase_.verable_.SubsecondsAsMantissa.Singleton.phrase(obj);

			if (obj<TimeSpan.Zero)
			{
				return $"N{lengthTxt }";	///note when zone is negative, we shall use plus sign; in fact the zone being negative shall be a zone marked positive.
			}
			else
			{
				return $"n{lengthTxt }";

			}

			

		}


		static public Verable_subsecondsAsMantissa Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Verable_subsecondsAsMantissa>.Instance;
			}
		}

	}
}
