using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._time.date.op_
{
	/// <summary>
	/// this is not constant, but a <see cref="date.of_.IUnary"/> with parameter binded to context|environment;
	/// </summary>
	static public class _TomorrowX
	{
		static public DateTime Op() {
			return DateTime.Today.AddDays(1);
		}
	}
}
