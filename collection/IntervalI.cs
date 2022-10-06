using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.time
{
	public partial interface IntervalI 
	{
		TimeI start
		{
			get;
			set;
		}
		TimeI end
		{
			get;
			set;
		}
	}
}
