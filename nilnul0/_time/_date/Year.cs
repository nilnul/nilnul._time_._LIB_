using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.num.integer;

namespace nilnul.time
{
	/// <summary>
	/// nilnul.num.integer.index_.Nonil
	/// 
	/// ordinal number.    1.Ad.  
	/// 0 is 1.BC, -1 is 2.BC, etc
	/// </summary>
	public partial class Year
	{
		private nilnul.num.integer.IntegerI _ordinal;

		public nilnul.num.integer.IntegerI ordinal
		{
			get { return _ordinal; }
			set { _ordinal = value; }
		}

		public Year(IntegerI ordinal)
		{
			this.ordinal = ordinal;
		}


					
		

	}
}
