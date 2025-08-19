using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time.elapse.be_
{
	public class Positive : time.elapse.BeI
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
