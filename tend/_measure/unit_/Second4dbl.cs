using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num;
using nilnul.num.real_;

namespace nilnul.time.seg._measure.unit_
{
	public class Second4dbl :

		Unit4dbl
	{
		public const double Mag = 1;
		public Second4dbl() : base(Mag)
		{
		}


		static public Second4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Second4dbl>.Instance;
			}
		}




	}
}
