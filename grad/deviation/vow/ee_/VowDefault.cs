using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time.grad.deviation.vow.ee_
{
	public class VowDefault<TVow> : vow.Ee
		where TVow : nilnul.obj.VowI2<TimeSpan>, new()
	{
		public VowDefault(TimeSpan val) : base(val, nilnul.obj_.Singleton<TVow>.Instance)
		{
		}
	}
}
