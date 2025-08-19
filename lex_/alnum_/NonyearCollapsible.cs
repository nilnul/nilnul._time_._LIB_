using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time_.datetime.lex_.alnum_
{
	/// <summary>
	/// year in at least 3 digits; other parts are collapsible;
	/// eg:
	///		2025y
	///		2025y01
	///		2025y0203
	///		2025y020301
	///		2025y0203010405
	///		2025y0203010405s
	///		
	/// </summary>
	public class NonyearCollapse :
		nilnul.time_.datetime.PhraseA
		,
		nilnul.time_.datetime.ParseI
	{
		/// <summary>
		/// exception when: year is less than 1 or greater than 9999.
		/// </summary>

		public const string FORMAT = @"yyyy\yMMddHHmmss\sFFFFFFF"; // "F..." discards trailing zeros
		public const int yCount = 4;
		public override string phrase(DateTime obj)
		{
			// we need the year to be at least three digits to remove the ambiguity of "22" as "022" ,not "2022"
			var r = obj.ToString(
				FORMAT
			);

			//var ss = new StringBuilder(r);

			if (r.EndsWith("s"))  /// fractional is empty
			{
				r = r.TrimEnd('s');

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
		
			//remove some zeros;

			//if (r.StartsWith("00"))
			//{
			//	r = r.Substring(2);
			//}
			//else

			if (r.StartsWith("0"))
			{
				r = r.Substring(1);
			}



			return r;


			///collapse;
			///



		}
		public DateTime? parseAsNulable(string x1111) {
			try
			{
				return parse(x1111);
			}
			catch (ArgumentException)
			{
				return null;
				///throw;
			}
			//catch (Exception)
			//{
			//	return null;
			//	///throw;
			//}

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
			if (yIndex < 3)	///eg: 12y
			{
				throw new ArgumentException(
					$"For {x1111}, we need the year to be at least three digits to remove the ambiguity of 22 as 022 or 2022;"
				);

			}

			var yrAft = x1111.Substring(
				yIndex + 1
			);


			var yrAftSb = new StringBuilder(yrAft);

			if (yrAftSb.Length == 0)
			{
				yrAftSb.Append("01");
			}

			if (yrAftSb.Length == 2)
			{
				yrAftSb.Append("01");
			}

			if (yrAftSb.Length < 4)
			{
				throw new ArgumentException(
					$"length of the part after year in {x1111} is not 0 or 2 , and is less than 4;"
				);
			}

			const int yrAftSub_fullLen = 4 + 6 + 1 /* the s*/;

			if (yrAftSb.Length < yrAftSub_fullLen)
			{
				if (yrAftSb.Length % 2 == 1)
				{
					throw new ArgumentException(
						$"length of the part after year in {x1111} is less than 10, but is not even"
					);
				}
				yrAftSb.Append('0', yrAftSub_fullLen - yrAftSb.Length - 1);
				yrAftSb.Append(@"s");
			}

			yrAftSb.Insert(0, x1111.Substring(0, yIndex + 1));  /// prepend "025" the year to "010203" the hour minute second;
			if (yIndex < yCount)
			{
				yrAftSb.Insert(0, new string('0', yCount - yIndex));    /// prepend 0s to "025" to make it "0025"

			}

			//	var sb2str = yrAftSb.ToString();

			//if (yIndex<3)
			//{
			//	yrAftSb.Insert(
			//		'0', 3-yIndex
			//	);

			//}

			return DateTime.ParseExact(yrAftSb.ToString(), FORMAT
				,
				null
				//CultureInfo.InvariantCulture
				//, DateTimeStyles.RoundtripKind
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
