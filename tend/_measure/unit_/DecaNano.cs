using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num;
using nilnul.num.real_;

namespace nilnul.time.seg._measure.unit_
{
	/// <summary>
	/// one tick is equial to 100 nano
	/// </summary>
	public class DecaNano4Dbl :
		Unit4dbl
		,

		Unit4dblI
	{
		public const  double Mag = Nano4dbl.Mag*100;
		public DecaNano4Dbl():base( Mag)
		{
		}

	

		static public DecaNano4Dbl Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<DecaNano4Dbl>.Instance;
			}
		}

	}
}
