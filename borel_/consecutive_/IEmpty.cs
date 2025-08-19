using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time.borel_.consecutive_
{
	/// <summary>
	/// </summary>
	/// <remarks>
	///	 empty is regarded as both closed and open
	/// </remarks>
	internal interface IEmpty:IConsecutive
		,
		IOpen
		,consecutive_.ICloze
	{
	}


}
