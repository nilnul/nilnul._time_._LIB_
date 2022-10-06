using nilnul.num.real_;
using nilnul.time.seg._measure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time
{
	/// <summary>
	/// how long is the time. This is a nonneg value in line with nilnul.geometry.linear
	/// </summary>
	public interface IDuration : seg.IMeasure
	{

	}

	public interface Duration4dblI<T>
		:
		nilnul.obj.Measure4dblI<T>
		where T : seg._measure.Unit4dblI

	{

	}
	public interface Duration4dblI
		:
		Duration4dblI<Unit4dblI>

	{

	}

	public class Duration4dbl<T>
		:
		nilnul.obj.Measure4dbl<T>
		,
		Duration4dblI<T>
		,
		IDuration
		where T : seg._measure.Unit4dblI
	{
		public Duration4dbl(NonnegOfDoubleI amount, T unit) : base(amount, unit)
		{
		}

		public Duration4dbl(NonnegOfDouble amount, T unit) : base(amount, unit)
		{
		}
		public Duration4dbl(double x, T unit):base(x,unit )
		{

		}

	}
	public class Duration4dbl
		: Duration4dbl<seg._measure.Unit4dblI>
		,
		Duration4dblI
	{
		public Duration4dbl(NonnegOfDoubleI amount, Unit4dblI unit) : base(amount, unit)
		{
		}

		public Duration4dbl(NonnegOfDouble amount, Unit4dblI unit) : base(amount, unit)
		{
		}

		public Duration4dbl(double x, Unit4dblI unit) : base(x, unit)
		{
		}
		public Duration4dbl(double x) : this(
			x, seg._measure.Unit4dbl.Singleton
		)
		{

		}
	}
}
