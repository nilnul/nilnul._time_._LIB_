using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time_.datetime_.zoned.phrase_
{
	/// <summary>
	/// the timezone is appended using minus/plus such that the expression can be evaluted to get a Standard Time.
	/// </summary>
	public  class NilNulMinus
	{

		static public string ToOffset(DateTimeOffset timeOffset) {
			return timeOffset.ToString("yyyy.M.d#H:m:s") + nilnul.time.seg_.offset.to_.Txt.ToCompact (-timeOffset.Offset);

		}
		
		static public string ToOffset() {
			return ToOffset(DateTimeOffset.Now);

		}

		

	}
}
