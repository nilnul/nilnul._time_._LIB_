using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time_.datetime.lex_.word_.lodash_
{
	/// <summary>
	/// year in at least 3 digits; other parts are collapsible;
	/// </summary>
	public class NonyearCollapse :
		nilnul.time_.datetime.PhraseA
		,
		nilnul.time_.datetime.ParseI
	{
		/// <summary>
		/// exception when: year is less than 1 or greater than 9999.
		/// </summary>

		public const string FORMAT = @"yyyy\yMMddHHmmss_FFFFFFF"; // "F..." discards trailing zeros
		public const int yCount = 4;
		public override string phrase(DateTime obj)
		{
			// we need the year to be at least three digits to remove the ambiguity of "22" as "022" ,not "2022"
			var r = obj.ToString(
				FORMAT
			);

			//var ss = new StringBuilder(r);

			if (r.EndsWith("_"))  /// fractional is empty
			{
				r = r.TrimEnd('_');

				var trimmedClockPair = 0;
				while (r.EndsWith("00"))  // clock zeros;
				{
					trimmedClockPair++;
					r = r.Substring(0, r.Length - 2);
				}
				if (trimmedClockPair == 3) //clock are all zeros;
				{
					if (r.EndsWith("01")) //day
					{
						r = r.Substring(0, r.Length - 2);
						if (r.EndsWith("01")) //month
						{
							r = r.Substring(0, r.Length - 2);
						}

					}
				}

			}


			if (r.StartsWith("0"))
			{
				r = r.Substring(1);
			}



			return r;


			///collapse;
			///



		}

		public DateTime parse(string x1111)
		{
			//if (x1111.Length < 4)
			//{
			//	throw new ArgumentException(
			//		$"{x1111}.length cannot be less than 4;"
			//	);
			//}

			var yIndex = x1111.IndexOf('y');
			if (yIndex < 0)
			{
				throw new ArgumentException(
					$"{x1111} doesnot have 'y'"
				);
			}
			if (yIndex < 3)
			{
				throw new ArgumentException(
					$"For {x1111}, we need the year to be at least three digits to remove the ambiguity of 22 as 022 or 2022;"
				);

			}

			var aftYr = x1111.Substring(
				yIndex + 1
			);


			var aftYrSb = new StringBuilder(aftYr);

			if (aftYrSb.Length == 0)
			{
				aftYrSb.Append("01");
			}

			if (aftYrSb.Length == 2)
			{
				aftYrSb.Append("01");
			}

			if (aftYrSb.Length < 4)
			{
				throw new ArgumentException(
					$"length of the part after year in {x1111} is not 0 or 2 , and is less than 4;"
				);
			}

			const int aftYrTilS = 4 + 6 + 1 /* the s*/;

			if (aftYrSb.Length < aftYrTilS)
			{
				if (aftYrSb.Length % 2 == 1)
				{
					throw new ArgumentException(
						$"length of the part after year in {x1111} is less than 10, but is not even"
					);
				}
				aftYrSb.Append('0', aftYrTilS - aftYrSb.Length - 1);
				aftYrSb.Append(@"_");
			}

			aftYrSb.Insert(0, x1111.Substring(0, yIndex + 1));

			if (yIndex < yCount)
			{
				aftYrSb.Insert(0, new string('0', yCount - yIndex));

			}


			return DateTime.ParseExact(aftYrSb.ToString(), FORMAT
				,
				null
				//CultureInfo.InvariantCulture
				, DateTimeStyles.RoundtripKind
				);
		}


		static public NonyearCollapse Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<NonyearCollapse>.Instance;
			}
		}


	}
}
