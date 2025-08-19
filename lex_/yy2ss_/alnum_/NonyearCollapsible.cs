using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time_.nonfract.lex_.alnum_
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

		public const string FORMAT = @"yyyy\yMMddHHmmss";
		public const int yCount = 4;
		public override string phrase(DateTime obj)
		{
			// we need the year to be at least three digits to remove the ambiguity of "22" as "022" ,not "2022"
			var r = obj.ToString(
				FORMAT
			);

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

			if (r.StartsWith("0"))
			{
				r = r.Substring(1);
			}

			return r;

		}

		public DateTime parse(string x1111)
		{


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

			var yrAft = x1111.Substring(
				yIndex + 1
			);
			if (yrAft.Length % 2 == 1)
			{
				throw new ArgumentException(
					$"length of the part after year in {x1111} is not even;"
				);

			}


			var yrAft_asSb = new StringBuilder(yrAft);

			if (yrAft_asSb.Length == 0)
			{
				yrAft_asSb.Append("01");
			}

			if (yrAft_asSb.Length == 2)
			{
				yrAft_asSb.Append("01");
			}


			const int yrAftSub_fullLen = 4 + 6  ;

			if (yrAft_asSb.Length < yrAftSub_fullLen)
			{
				yrAft_asSb.Append('0', yrAftSub_fullLen - yrAft_asSb.Length - 1);
			}

			yrAft_asSb.Insert(0, x1111.Substring(0, yIndex + 1));

			if (yIndex < yCount)
			{
				yrAft_asSb.Insert(0, new string('0', yCount - yIndex));

			}



			return DateTime.ParseExact(
				yrAft_asSb.ToString()
				, FORMAT
				,
				null
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
