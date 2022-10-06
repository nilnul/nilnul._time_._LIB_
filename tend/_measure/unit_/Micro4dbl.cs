using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num;

namespace nilnul.time.seg._measure.unit_
{
	public class Micro4dbl :
		Unit4dbl
		,

		Unit4dblI
	{
		public const double Mag = Milli4dbl.Mag/1000;
		public Micro4dbl():base(Mag)
		{
		}


		static public Micro4dbl Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Micro4dbl>.Instance;
			}
		}

	}
}
