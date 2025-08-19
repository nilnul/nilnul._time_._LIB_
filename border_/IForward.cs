using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time.border_
{
	/// <summary>
	/// upward
	/// </summary>
	/// alias:
	///		upward
	///			, go bigger.
	///		forward
	///			,same direction as the axis's arrow head.
	///			, is not favored, as 前(forward) can mean 以前(in the past where it's previously covered); use upward is less confusing.
	///		lower, the lower border.
	///			,the lower border
	///		bigward, facing bigger.
	///		
	public interface IForward
		:time.IBorel
	{
	}

}
