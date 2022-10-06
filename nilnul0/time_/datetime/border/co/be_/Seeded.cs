using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time_.datetime.border.co.be_
{
	public class Seeded : BeI
	{
		public bool be(Co obj)
		{
			return Single.Singleton.be(obj) || Spanned.Singleton.be(obj);
		}



		static public readonly Seeded Singleton = nilnul.obj.SingletonByDefault<Seeded>.Instance;

	}
}
