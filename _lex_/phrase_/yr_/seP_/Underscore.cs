using nilnul.time_.datetime._lex_.phrase_.yr_;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time._lex_.phrase_.yr_.seP_
{
	/// <summary>
	/// underscore implies a decimal point: this is a decimal, and this is followed by mantissa/fraction.
	/// 
	/// </summary>
	public class Underscore
		:
		DecimalSubsecond
		//nilnul.time_.datetime.PhraseA
	{
		

		public Underscore() : base("_")
		{
		}


		static public Underscore Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Underscore>.Instance;
			}
		}


	}
}
