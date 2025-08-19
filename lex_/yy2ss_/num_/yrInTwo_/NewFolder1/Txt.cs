using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time.to
{
	[Obsolete(nameof(nilnul.time.to_.TxtA))]
	public class Txt
	{
		static public string ToTxt(DateTime time) {
			return time.ToString("yyMMddHHmmss");
		}
		static public string ToTxtFull(DateTime time) {
			return time.ToString("yyMMddHHmmss"+ nilnul.txt.op_.RepeatX.Repeat("f",7));
		}

		static public string ToTxtFull() {
			return ToTxtFull(DateTime.UtcNow);
		}




		static public string ToTxt() {
            return ToTxt(DateTime.UtcNow);
		}





		static public string Eval() {
			return ToTxt(DateTime.Now);
		}
	}
}
