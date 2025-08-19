using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time.tend
{
	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		duration
	///		period
	///	<see cref="nilnul.time.IDuration"/>
	///	vs:
	///		offset
	///			,which can be negative.
	///			<see cref="nilnul.obj.IMetric"/>
	///			
	public interface IMeasure
		:
		nilnul.collective.IMeasure
		,
		nilnul.ral_.ord_.continuum.tend.ILength
		//nilnul.obj.IMeasure
	{
	}
}
