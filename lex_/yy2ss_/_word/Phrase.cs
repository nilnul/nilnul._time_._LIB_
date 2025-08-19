using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time.lex_.yy2ss_._word
{
	public class Phrase :
		nilnul.time_.datetime.PhraseA
	{
		public const string FORMAT_FOR_YY2SS = "yyMMdd_HHmmss";
		public override string phrase(DateTime obj)
		{
			return obj.ToString(FORMAT_FOR_YY2SS );
		}

		static public Phrase Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Phrase>.Instance;
			}
		}
	}
}
