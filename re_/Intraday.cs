using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time.re_
{
	/// <summary>
	/// 
	/// </summary>
	/// vs:interday
	public class Intraday
		: nilnul.time.ReI
	{
		public bool re(DateTime a, DateTime b)
		{
			return b.Date == a.Date;
		}

		static public Intraday Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Intraday>.Instance;
			}
		}

	}
}
