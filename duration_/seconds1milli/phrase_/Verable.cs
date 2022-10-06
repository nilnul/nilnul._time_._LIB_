using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time.length_.seconds1milli.phrase_
{
	/// <summary>
	/// midNotation
	/// no punc but "_", using only letters and underscores such as to be used in ver.
	/// </summary>
	static public class _VerableX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="seconds"></param>
		/// <param name="millis"></param>
		/// <returns>
		/// s in the middle, or in the end, or in nowhere if the string is empty
		/// </returns>
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
					return $"{seconds}s"; //eg: 0s; 3s
				}

			}
			else
			{

				return $"{seconds}s{millis.ToString().PadLeft(3, '0')}";	//eg: 0s005
			}



		}




	}
}
