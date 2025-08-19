using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time.be_
{
	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		<see cref="time.bound.of_.IRecent"/>
	///		before
	public class Past
		:
		nilnul.time.BeA
		,
		nilnul.time.BeI
	{
		public override bool be(in DateTime val)
		{
			return val	<
				DateTime.Now //local
			;

		}

	}

}
