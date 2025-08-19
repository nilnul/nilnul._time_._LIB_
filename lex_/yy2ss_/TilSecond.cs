using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time_.datetime.phrase_
{
	public abstract class TilSecondA:nilnul.time.ToI<string>
	{

		static public string ToTxt(DateTime time) {
			return time.ToString("yyMMddHHmmss");
		}
		[Obsolete(nameof(Full))]
		static public string ToTxtFull(DateTime time) {
			return time.ToString("yyMMddHHmmss"+ nilnul.txt.op_.RepeatX.Repeat("f",7));
		}


		static public string ToTxtFull() {
			return ToTxtFull(DateTime.UtcNow);
		}

		static public string LocalToTxtFull() {
			return ToTxtFull(DateTime.Now);
		}




		static public string ToTxt() {
            return ToTxt(DateTime.UtcNow);
		}





		static public string Eval() {
			return ToTxt(DateTime.Now);
		}

		public abstract string to(DateTime src)
		;
	}
}
