using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num;
using nilnul.num.real_;
using nilnul.obj._measure._unit_;

namespace nilnul.time.seg._measure.unit_
{
	public class Day :


		UnitI
	{


		public RealI _magnitude => new nilnul.num.real_.Quotient(24*60*60);

		static public Day Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Day>.Instance;
			}
		}

		public PositiveI magnitude => new nilnul.num.real_.Positive(_magnitude);
	}
}
