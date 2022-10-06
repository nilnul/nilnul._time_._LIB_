using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num;
using nilnul.num.real_;

namespace nilnul.time.seg._measure.unit_
{
	public class Minute4dbl :

		Unit4dbl
	{
		public const double Mag = 60;
		public Minute4dbl() : base(Mag)
		{
		}


		static public Minute4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Minute4dbl>.Instance;
			}
		}




	}
}
