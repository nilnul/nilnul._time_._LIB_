using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time.xt.bound_
{
	/// <summary>
	/// excluding infinity as well as neg inf;
	/// </summary>
	public interface INoInf:
			nilnul.num.real.xt_.IFinite
	{
	}
}
