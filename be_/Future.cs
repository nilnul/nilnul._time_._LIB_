using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time.be_
{
	/// <summary>
	/// <see cref="time.bound.of_.IImmediate"/>
	/// </summary>
	/// alias:
	///		after
	public class Future
		:
		nilnul.time.BeA
		,
		nilnul.time.BeI
	{
		public override bool be(in DateTime val)
		{
			return val	>
				DateTime.Now //local
			;

		}

	}
}
