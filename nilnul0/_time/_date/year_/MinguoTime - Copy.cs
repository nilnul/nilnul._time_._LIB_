﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.time
{

	public partial class MinguoTime
	{
		public const int MinguoZeroYearInAd = 1911;

		static public int ToAdYear(int minguoYear) {
			if (minguoYear>0)
			{
				return MinguoZeroYearInAd + minguoYear;

			}
			if (minguoYear<0)
			{
				return MinguoZeroYearInAd + minguoYear + 1;
				
			}
			throw new ArgumentOutOfRangeException("1911年是民前1年；1912年是民国1年。"); /*ord|index without nil*/
		}

		/*民前”，例如，民前一年就是1911年*/


		static public int ToAdYear()
		{
			var now=new DateTime();
			var year = now.Year;
			return ToAdYear(year);
		}




		


		

		
	}
}
