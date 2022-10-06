using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.cosmo.time
{
	public partial interface VarI
		:
		VarI<TimeI>
		,
		TimeI
	{
	}
}
