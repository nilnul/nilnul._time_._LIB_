using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num;
using nilnul.num.real_;

namespace nilnul.time.seg._measure.unit_
{
	public class Nano :
		Unit
		,

		UnitI
	{
		static public RealI _mag => new nilnul.num.real_.Quotient(1,1000_000);
		public Nano():base( _mag)
		{
		}

	

		static public Nano Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Nano>.Instance;
			}
		}

	}
}
