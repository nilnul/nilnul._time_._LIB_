using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num;
using nilnul.num.real_;

namespace nilnul.time.seg._measure.unit_
{
	public class Hour :
		Unit,

		UnitI
	{
		static public RealI _Mag => new nilnul.num.real_.Quotient(60*60);
		public Hour():base(_Mag)
		{
		}


		static public Hour Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Hour>.Instance;
			}
		}

	}
}
