using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time.grad.deviation.be_
{
	public class Positive : time.grad.deviation.BeI
	{
		public bool be(TimeSpan obj)
		{
			return obj> TimeSpan.Zero ;
			//throw new NotImplementedException();
		}

		static public Positive Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Positive>.Instance;
			}
		}

	}
}
