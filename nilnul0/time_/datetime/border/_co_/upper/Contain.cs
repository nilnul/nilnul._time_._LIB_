using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time_.datetime.border._co_.upper
{
	public class Contain
	{
		static public bool Eval(Border border, DateTime time) {
			return nilnul.time_.datetime.border.At.Eval(border, time) || border.mark>time;
		}
	}
}
