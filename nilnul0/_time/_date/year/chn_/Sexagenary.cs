using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._time._date.year.chn_
{
	/// <summary>
	/// The sexagenary cycle, also known as the gānzhī (干支) or stems-and-branches, is a cycle of sixty terms, each corresponding to one year, thus amounting to a total of sixty years every cycle
	/// </summary>
	static public class _SexagenaryX
	{
		/// <summary>
		///  stream of (heavenly stem, earthly branch) pairs, starting from 0,0, with 60 as the periodicity of the stream.
		/// </summary>
		/// <remarks>
		///
		/// </remarks>
		/// <returns></returns>
		static public IEnumerable<(int stem, int branch)> Stream()
		{

			int i = 0;
			int j = 0;
			while (true)
			{
				yield return (
					i, j
				);

				i++;
				if (i >= 10) // 10 stems
				{
					i = 0;
				}

				j++;
				if (j >= 12) // 12 branches
				{
					j = 0;
				}


			}
			
		}
		static public readonly (int stem, int branch)[] CYCLE = Stream().Take(60).ToArray();



		/// <summary>
		/// 甲子
		/// </summary>
		public const int BASE_YEAR = 1984;
		static public (int stem, int branch) _Sexage_0positive(int year)
		{

			int index = (year -BASE_YEAR) % 60;
			if (index < 0)
			{
				index += 60; // Handle negative years
			}

			return CYCLE[index];
		}


		static public string _SexageAsTxt_0positive(int year)
		{



			(int stem, int branch) sexage = _Sexage_0positive(year);

			return $"{_sexage._StemX.SORTIE[sexage.stem]}{_sexage._BranchX.SORTIE[sexage.branch]}";
		}


	}
}
