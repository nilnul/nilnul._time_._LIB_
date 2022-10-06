using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time.seg_.offset.to_
{
	public class Txt
	{
		/// <summary>
		/// take span as offset; that is, precise to the minus.
		/// </summary>
		/// <param name="span"></param>
		/// <returns></returns>
		static public string ToCompact(TimeSpan _offset) {
			return _offset.Hours.ToString()
				+(
				_offset.Minutes == 0 ?  "": ":"+ _offset.Minutes.ToString()
			);
		}
	}
}
