using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time_.datetime._lex_.phrase_.yr_
{
	/// <summary>
	/// 7 digits for splitSecond
	/// </summary>
	public class SevenSubsecond : nilnul.time_.datetime.PhraseA
		
	{
		/// <summary>
		/// yy is 2 in width, becuz:
		///		1) in the year end and the begining of next year, we need the 2-digits of year to distinguish the time point around the year end/begin.
		///		2) two-digits is enough to different the auto-generated timestamp.
		///	The problem with 2-digits year is:
		///		1) one person will be around the change of millennium.
		///		2) one perso will live from the start of millennium to its end.
		///		3) 100 years are short for the inneration of computer storage technology.
		///		4) if multiple persons work in the same repo, at different times, they may have different interpretations of the year.
		///	4-digits:
		///		1) too long to write. not short enough in contrast with 2-digits.
		///		2) not the same length as month and day, hour, minute, second.
		///		
		///	conclusion:
		///		we may consider using 4-digits year. 
		/// </summary>

		[Obsolete(nameof(datetime.lex_.yr_.SevenSplit.Singleton.phrase))]
		public override string phrase(DateTime obj)
		{
			return datetime.lex_.yr_.SevenSplit.Singleton.phrase(obj);
		}

		

		static public SevenSubsecond Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<SevenSubsecond>.Instance;
			}
		}


	}
}
