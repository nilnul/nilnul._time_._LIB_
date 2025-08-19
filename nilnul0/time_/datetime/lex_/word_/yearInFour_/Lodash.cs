using nilnul.time_.datetime._lex_.phrase_.yr_;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time_.datetime.lex_.word_.yearInFour_
{
	/// <summary>
	/// underscore implies a decimal point: this is a decimal, and this is followed by mantissa/fraction.
	/// 
	/// </summary>
	public class Lodash
		:datetime.LexI
	{
		public const string FORMAT = @"yyyy\yMMddHHmmss_FFFFFFF";



		static public Lodash Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Lodash>.Instance;
			}
		}

		public DateTime parse(string x)
		{
			if (x.Length==5+4+6)
			{
				x = x + "_";
			}
			return DateTime.ParseExact(x,FORMAT,null);
		}

		public string phrase(DateTime obj)
		{
			return obj.ToString(
				FORMAT
			).Trim('_');
		}
	}
}
