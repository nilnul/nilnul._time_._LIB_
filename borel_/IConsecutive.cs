using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time.borel_
{
	/// <summary>
	/// intersection of <see cref="time.IBorder"/>. the result is consecutive.
	/// 
	/// including:
	///		empty
	///		,
	///		<see cref="xt.bound_.INoInf"/>
	///	excluding nonjoint bounds.
	/// </summary>
	/// 
	/// alias:
	///		contiguous
	///		continuous
	///		consecutive
	///		joint
	/// 
	public interface IConsecutive:
		time.IBorel
		//,
		//time.set_.IBorel
	
	{
	}


}
