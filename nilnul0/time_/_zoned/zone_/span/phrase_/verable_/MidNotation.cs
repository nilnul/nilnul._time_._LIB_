using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time_._zoned.zone_.span.phrase_.verable_
{
	/// <summary>
	/// This is not preferable, as the trailing num might be paraphrased otherwise.
	/// </summary>
	public class MidNotation
		: nilnul.obj.PhraseI<TimeSpan>
	{
		public string phrase(TimeSpan obj)
		{




			var lengthTxt = time.length_.span.phrase_.verable_.MidNotation4SecondsSub_assumeNonneg.Singleton.phrase(obj);

			if (obj < TimeSpan.Zero)
			{
				return $"n{lengthTxt }";
			}
			else
			{
				return $"N{lengthTxt }";

			}

		}


		static public MidNotation Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<MidNotation>.Instance;
			}
		}

	}
}
