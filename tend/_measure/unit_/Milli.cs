using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num;
using nilnul.num.quotient.stream_.convergent_;

namespace nilnul.time.seg._measure.unit_
{
	public class Milli :
		Unit
,
		UnitI
	{
		public static  RealI _Mag => new nilnul.num.real_.Quotient(1,1000);
		public Milli():base(_Mag)
		{
		}


		static public Milli Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Milli>.Instance;
			}
		}


	}
}
