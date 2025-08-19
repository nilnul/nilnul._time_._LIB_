using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time.elapse.be_
{
	public class Nonneg : time.elapse.BeI
	{
		public bool be(TimeSpan obj)
		{
			return obj>= TimeSpan.Zero ;
			//throw new NotImplementedException();
		}

		static public Nonneg Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Nonneg>.Instance;
			}
		}

	}
}
