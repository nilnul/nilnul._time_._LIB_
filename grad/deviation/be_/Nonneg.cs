using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time.grad.deviation.be_
{
	public class Nonneg : time.grad.deviation.BeI
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
