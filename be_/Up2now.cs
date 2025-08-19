using System;

namespace nilnul.time.be_
{
	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		截至
	///		as of,（asof）, "up to"，
	///		by
	public class Up2now
		:
		nilnul.time.BeA
		,
		nilnul.time.BeI
	{
		public override bool be(in DateTime val)
		{
			return val	<=
				DateTime.Now //local
			;

		}

	}


}
