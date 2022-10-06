using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time.grad.deviation.be.vow_
{
	public class BeDefault<TBe> : deviation.be.Vow
		where TBe: nilnul.obj.BeI1<TimeSpan>,new()
	{
		public BeDefault() : base(nilnul.obj_.Singleton<TBe>.Instance)
		{
		}

		
	}
}
