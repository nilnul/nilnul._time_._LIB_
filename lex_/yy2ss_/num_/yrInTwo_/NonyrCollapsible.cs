using nilnul.num.integer;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time_.nonfract.lex_.num_.yrInTwo_
{
	/// <summary>
	/// non year is collapsed in pair;
	/// </summary>
	public class NonyrCollapse :
		nilnul.time_.datetime.PhraseA
		,
		nilnul.time_.datetime.ParseI
	{

		public override string phrase(DateTime obj)
		{
			var r = num_.YrInTwo.Singleton.phrase(obj);

			var trimmedClockPair = 0;
			while (r.EndsWith("00"))
			{
				trimmedClockPair++;
				r = r.Substring(0, r.Length - 2);
			}
			if (trimmedClockPair == 3)
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
			if (x1111.Length.IsOdd())
			{
				throw new ArgumentException(
					$"{x1111}.length is odd;"
				);

			}
			if (x1111.Length==0)
			{
				throw new ArgumentException(
					$"{x1111}.length is 0;"
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

			//if (x.Length < 6)
			//{
			//	throw new Exception(
			//		$"{x1111}.length is not 2 or 4, and is lt 6;"
			//	);
			//}
			if (x.Length < 12)
			{
				x.Append('0', 12 - x.Length);
			}

			return num_.YrInTwo.Singleton.parse(x.ToString());
		}


		static public NonyrCollapse Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<NonyrCollapse>.Instance;
			}
		}


	}
}
