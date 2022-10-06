using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time_.datetime.tilSeconds.phrase_.yr_
{
	public class NoSep : nilnul.time_.datetime.PhraseA
	{

	

		public const string FORMAT4YYMMDDHHMMSS = "yyMMddHHmmss";
		public override string phrase(DateTime obj)
		{
			return obj.ToString(FORMAT4YYMMDDHHMMSS );
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
