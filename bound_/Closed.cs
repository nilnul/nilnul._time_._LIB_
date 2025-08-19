using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time.bound_
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	///
	/// in rfc5545, vJournal as a transparent task, acts as a bound|appropriate timespan;
	/// 
	/// </remarks>
	/// alias:
	///		range
	///		span
	///		period
	///		clamp
	///		<see cref="nilnul.obj.IClasp"/>
	///	vs:
	///		<see cref="nilnul.obj.IClamp"/> which is <see cref="nilnul.obj.betwixt_.IClosed"/>
	///		grad
	///			grad can point into negative direction.
	/// 
	public interface IClosed
	{
	}
}
