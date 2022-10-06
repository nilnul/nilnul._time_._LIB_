using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// alias:
	///		step
	///			like string, implying that the two points have order.
	///			unlike sortie, the two points can be the same.
	///		grad
	///		
	/// </remarks>
	[Obsolete(nameof(IGrad))]
	public interface  IStep:IGrad
	{
	}
}
