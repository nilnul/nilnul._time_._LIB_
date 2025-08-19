using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time_.datetime._lex_.phrase_.yr_.decimalSubsecond_
{
	/// <summary>
	/// This is not preferable, as we use "decimal", not fixed length
	/// </summary>
	public class NoSep
		:
		DecimalSubsecond
		//nilnul.time_.datetime.PhraseA
	{
		

		public NoSep() : base("")
		{
		}


		static public NoSep Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<NoSep>.Instance;
			}
		}


	}
}
