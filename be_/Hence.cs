using System;

namespace nilnul.time.be_
{
	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		自此
	///		asap
	public class Hence
		:
		nilnul.time.BeA
		,
		nilnul.time.BeI
	{
		public override bool be(in DateTime val)
		{
			return val	>=
				DateTime.Now //local
			;

		}

	}


}
