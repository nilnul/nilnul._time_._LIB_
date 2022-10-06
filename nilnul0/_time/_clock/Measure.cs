using nilnul._time._clock._measure;
using nilnul.num.real_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._time._clock
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <remarks>
	/// </remarks>
	/// alias:
	///		departure
	///		deviation
	/// <see cref="time.IDuration"/>
	/// for signed, <see cref="time.grad.IDeviation_bySignedMeasure"/>
	public class Measure4dbl<T>
		: nilnul.obj.Measure4dbl<
			T
		>
		where T : _clock._measure.Unit4dblI
	{
		public Measure4dbl(NonnegOfDoubleI amount, T unit) : base(amount, unit)
		{
		}

		public Measure4dbl(NonnegOfDouble amount, T unit) : base(amount, unit)
		{
		}

		public Measure4dbl(double amount, T unit) : base(amount, unit)
		{
		}

		public Measure4dbl(long amount, T unit) : base(amount, unit)
		{
		}

		public Measure4dbl(int amount, T unit) : base(amount, unit)
		{
		}
	}

	public class Measure4dbl :
		Measure4dbl<_measure.Unit4dblI>
	{
		public Measure4dbl(NonnegOfDoubleI amount, Unit4dblI unit) : base(amount, unit)
		{
		}

		public Measure4dbl(NonnegOfDouble amount, Unit4dblI unit) : base(amount, unit)
		{
		}

		public Measure4dbl(double amount, Unit4dblI unit) : base(amount, unit)
		{
		}

		public Measure4dbl(long amount, Unit4dblI unit) : base(amount, unit)
		{
		}

		public Measure4dbl(int amount, Unit4dblI unit) : base(amount, unit)
		{
		}
	}


}
