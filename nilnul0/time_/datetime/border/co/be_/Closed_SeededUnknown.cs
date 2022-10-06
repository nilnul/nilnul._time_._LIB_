using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time_.datetime.border.co.be_
{
	public class Closed_SeededUnknown : BeI
	{
		public bool be(Co obj)
		{
			return obj.left.beClose && obj.right.beClose;

			//throw new NotImplementedException();
		}

		static public readonly Closed_SeededUnknown Singleton = nilnul.obj.SingletonByDefault<Closed_SeededUnknown>.Instance;

	}
}
