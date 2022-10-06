using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time_.datetime.lexer_.yeared_
{
	/// <summary>
	/// this 
	/// </summary>
	public class Full : nilnul.time_.datetime.PhraseA
		,nilnul.time_.datetime.ParseI
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

		static public Full Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Full>.Instance;
			}
		}

	}
}
