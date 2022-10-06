using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time.length_.seconds1milli.phrase_.verable_
{
	/// <summary>
	/// no "s" at the end. "_" might appear; "_" cannot lead.
	/// </summary>
	/// <remarks>
	/// alias:
	///		mantissa
	/// </remarks>
	static public class _UnderscoreX
	{
		static public string Phrase_assumeNonnegs(int seconds, int millis)
		{

			if (millis == 0)
			{
				if (seconds == 0)
				{
					return "";
				}
				else
				{
					return $"{seconds}"; //eg: 0s; 3s
				}

			}
			else
			{

				///when seconds is 0, to prepend 0 to make this still composable in ver.
				return $"{seconds}_{millis.ToString().PadLeft(3, '0')}";    //eg: 0_005. no "s" at the end
			}



		}


	}
}
