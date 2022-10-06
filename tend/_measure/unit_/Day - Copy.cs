using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num;
using nilnul.num.real_;

namespace nilnul.time.seg._measure.unit_
{
	public class Day4dbl :


		Unit4dbl
	{
		public const double Mag = 24 * Hour4dbl.Mag;

		public Day4dbl() : base(Mag)
		{
		}

		static public Day4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Day4dbl>.Instance;
			}
		}


	}
}
