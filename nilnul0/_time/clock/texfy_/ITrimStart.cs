using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._time.clock.phrase_
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// for example, when we version our nuget pak, the version is named as such: 1.1.230109.10149
	///		where 10149 is the hour minute and seconds, where the leading nils are trimmed; we need to keep the version short here as there might be some limit on how long the ver is, and the leading nils are sometimes inconsistently honored or not.
	/// </remarks>
	public interface ITrimStart
	{
		

	}
}
