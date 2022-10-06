using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time_.datetime.phrase_.ymd_
{
	public class Hyphened : YyMmDd
	{
		public Hyphened(): base("-")
		{
		}


		static public Hyphened Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Hyphened>.Instance;
			}
		}

	}
}
