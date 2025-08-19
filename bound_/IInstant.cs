using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time.bound_
{
	/// <summary>
	/// a singleton
	/// </summary>
	internal class IInstant
		:nilnul.time.set_.IInstant
		,
		bound_.IClosed
		,
		nilnul.obj.bound_.IClosed
		,
		nilnul.obj.bound_.closed_.ISingular
	{
	}


}
