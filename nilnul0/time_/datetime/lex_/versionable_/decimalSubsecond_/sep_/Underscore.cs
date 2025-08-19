using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time_.datetime._lex_.phrase_.yr_.decimalSubsecond_.seP_
{
	/// <summary>
	/// underscore implies a decimal point: this is a decimal, and this is followed by mantissa/fraction.
	/// 
	/// </summary>
	/// <remarks>
	/// <see cref="nilnul.txt_._versioned.version_.idable_.IAlnum"/>, we better avoid "_"
	/// </remarks>
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
