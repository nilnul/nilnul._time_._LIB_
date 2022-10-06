using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time_.datetime.phrase_.ymd_
{
	public class Dotted : YyMmDd
	{
		public Dotted(): base(".")
		{
		}


		static public Dotted Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Dotted>.Instance;
			}
		}

	}
}
