using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time_.datetime.lex_.alnum_.yrInTwo_
{
	/// <summary>
	/// </summary>
	public class CollapsibleByPair :
		nilnul.time_.datetime.PhraseA
		,
		nilnul.time_.datetime.ParseI
	{

		public const string FORMAT = @"yyMMddHHmmss\sFFFFFFF"; // "F..." discards trailing zeros
		public override string phrase(DateTime obj)
		{
			var r = obj.ToString(
				FORMAT
			);
			if (r.EndsWith("s"))
			{
				r = r.TrimEnd('s');

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


			}

			return r;


			///collapse;
			///



		}

		public DateTime parse(string x1111)
		{
			if (x1111.Length%2==1)
			{
				throw new Exception(
					$"{x1111}.length must be even number;"
				);
			}
			if (x1111.Length == 0)
			{
				throw new Exception(
					$"{x1111}.length must be nonnil;"
				);
			}

			var x = new StringBuilder(x1111);

			if (x.Length==2)
			{
				x.Append( "01" );
			}
			if (x.Length==4)
			{
				x.Append("01" );
			}

			//if (x.Length<6)
			//{
			//	throw new Exception(
			//		$"{x1111}.length is not 2 or 4, and is lt 6;"
			//	);
			//}

			if (x.Length<12)
			{
				x.Append( '0',12-x.Length);
			}
			x.Append(@"s");

			return DateTime.ParseExact(x.ToString(), FORMAT, CultureInfo.InvariantCulture
				//,DateTimeStyles.None
				);
		}


		static public CollapsibleByPair Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<CollapsibleByPair>.Instance;
			}
		}


	}
}
