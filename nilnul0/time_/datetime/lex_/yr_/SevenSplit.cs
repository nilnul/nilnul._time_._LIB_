using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time_.datetime.lex_.yr_
{
	/// <summary>
	/// </summary>
	public class SevenSplit :
		nilnul.time_.datetime.PhraseA
		,
		nilnul.time_.datetime.ParseI
	{
		
		public static string Format = "yyyyMMddHHmmss" + nilnul.txt.op_.RepeatX.Repeat("f", 7);
		public override string phrase(DateTime obj)
		{
			return obj.ToString(Format);
		}

		public DateTime parse(string x)
		{
			return DateTime.ParseExact(x, Format,CultureInfo.InvariantCulture
				//,DateTimeStyles.None
				);
		}

		static public SevenSplit Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<SevenSplit>.Instance;
			}
		}

	}
}
