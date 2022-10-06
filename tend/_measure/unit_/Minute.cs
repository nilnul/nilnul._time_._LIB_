using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num;
using nilnul.num.real_;

namespace nilnul.time.seg._measure.unit_
{
	public class Minute :

		UnitI
	{


		public RealI _mag => new nilnul.num.real_.Quotient(60);

		static public Minute Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Minute>.Instance;
			}
		}

		public PositiveI magnitude =>new nilnul.num.real_.Positive(_mag);
	}
}
