using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._time._clock
{
	public interface IDeviation
		:
		nilnul.obj.measure.ISigned
	{
	}

	public class Deviation4dbl<T>
		:
		nilnul.obj.measure.Signed4dbl<T>
		,
		IDeviation

		where T : _measure.Unit4dblI
	{
		public Deviation4dbl(double quantity0, T unit) : base(quantity0, unit)
		{
		}

		public Deviation4dbl(long amount, T unit) : base(amount, unit)
		{
		}

		public Deviation4dbl(int amount, T unit) : base(amount, unit)
		{
		}
	}
}
