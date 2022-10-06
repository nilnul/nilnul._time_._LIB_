using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time_.datetime.border.co.be_
{
	public class Spanned : BeI
	{
		public bool be(Co obj)
		{
			return obj.left.mark < obj.right.mark;
		}


		static public readonly Spanned Singleton = nilnul.obj.SingletonByDefault<Spanned>.Instance;


	}
}
