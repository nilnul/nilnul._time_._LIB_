using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time_.datetime.border
{
	public class At
	{
		static public bool Eval(Border border, DateTime time) {
			return border.openFalseCloseTrue && border.mark == time;
		}
	}
}
