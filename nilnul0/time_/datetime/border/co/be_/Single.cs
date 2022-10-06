using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time_.datetime.border.co.be_
{
	public class Single : BeI
	{
		public bool be(Co obj)
		{
			return Closed_SeededUnknown.Singleton.be(obj) && obj.left.mark == obj.right.mark;
		}


		static public readonly Single Singleton = nilnul.obj.SingletonByDefault<Single>.Instance;

	}
}
