using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul
{
	/// <summary>
	/// set the 0 point; set the unit. regards this as <see cref="nilnul.geometry.linear_.gauged"/>
	/// </summary>
	interface ITime {

	}
	/// <summary>
	/// we can define the time nonRecursively by using DateClock.
	/// or we can define the time recursively by first define DateClock with limited precision, the we define a timespan, then DateClock+timespan is also a timeI.
	/// <see cref="nameof(DateTime)"/> is the default implementation
	/// </summary>
	public interface TimeI
	{
	}
}
