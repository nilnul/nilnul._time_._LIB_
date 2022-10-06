using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time.grad.deviation.be
{
	public class Vow : nilnul.obj.be.Vow4<TimeSpan>
	{
		public Vow(BeI1<TimeSpan> be) : base(be)
		{
		}

		public Vow(Predicate<TimeSpan> predicate) : base(predicate)
		{
		}

		public Vow(Func<TimeSpan, bool> func) : base(func)
		{
		}
	}
}
