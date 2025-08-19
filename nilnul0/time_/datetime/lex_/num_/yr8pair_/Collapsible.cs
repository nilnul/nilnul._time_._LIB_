using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time_.datetime.lex_.num_.yrInTwo_
{
	/// <summary>
	/// eg:
	///		23
	///		2306
	///		230611
	///		2306110101010123456
	/// </summary>
	public class Collapsible :
		nilnul.time_.datetime.PhraseA
		,
		nilnul.time_.datetime.ParseI
	{

		public const string FORMAT = @"yyMMddHHmmssFFFFFFF"; // "F..." discards trailing zeros
		public override string phrase(DateTime obj)
		{
			var r = obj.ToString(FORMAT);

			r = r.TrimEnd('0');
			if (r.Length>=12)
			{
				return r;
			}
			if (r.Length % 2 == 1)
			{
				r = r + "0";
				return r;
			}

			if (r.Length == 6)
			{
				if (r.EndsWith("01"))
				{
					r = r.Substring(0, r.Length - 2);
					if (r.EndsWith("01"))
					{
						r = r.Substring(0, r.Length - 2);
					}

				}

			}
			return r;
		}

		public DateTime parse(string x1111)
		{
			if (x1111.Length % 2 == 1)
			{
				throw new ArgumentException(
					$"{x1111}.length must be even number;"
				);
			}
			if (x1111.Length == 0)
			{
				throw new ArgumentException(
					$"{x1111}.length must be nonnil;"
				);
			}

			var x = new StringBuilder(x1111);

			if (x.Length == 2)
			{
				x.Append("01");
			}
			if (x.Length == 4)
			{
				x.Append("01");
			}

	
			if (x.Length < 12)
			{
				x.Append('0', 12 - x.Length);
			}

			return DateTime.ParseExact(x.ToString(), FORMAT, CultureInfo.InvariantCulture
				//,DateTimeStyles.None
				);
		}


		static public Collapsible Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Collapsible>.Instance;
			}
		}


	}
}
