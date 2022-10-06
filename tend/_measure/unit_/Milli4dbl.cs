using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num;

namespace nilnul.time.seg._measure.unit_
{
	public class Milli4dbl :
		Unit4dbl
		,

		Unit4dblI
	{
		public const double Mag = 1d /1000;
		public Milli4dbl():base(Mag)
		{
		}


		static public Milli4dbl Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Milli4dbl>.Instance;
			}
		}

	}
}
