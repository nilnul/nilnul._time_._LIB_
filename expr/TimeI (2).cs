using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.element;

namespace nilnul.cosmo.time
{

	/// <summary>
	///
	/// </summary>
	public partial interface TimeI
		:IComparable<TimeI>
		,
		IEquatable<TimeI>
		,
		HaveBothInfiniteI<TimeI>
		
		,

		ExprI<TimeI>
		,ContinuousI<TimeI>

		
		//:IReal
	{
		
	}
}
