using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._time._date.year.chn_
{
	static public class _ZodiacX
	{
		/// <summary>
		/// The year of the Rat in the Chinese zodiac cycle, which starts from 1900.
		/// </summary>
		public const int YEAR_RAT = 1900; // The year of the Rat in the Chinese zodiac cycle
		static public _zodiac.Animal_ _Zodiac_0positive(int year)
		{
			int index = (year - YEAR_RAT) % 12;
			if (index < 0)
			{
				index += 12; // Handle years before 1900
			}
			return (_zodiac.Animal_)index;
		}
	}
}
