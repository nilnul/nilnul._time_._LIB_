using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time_.datetime_.txt_
{
	 static public class _FullX
	{
		public const string FORMAT = "yyMMddHHmmss";
		static public DateTime Parse(string s) {
			return DateTime.ParseExact(s, FORMAT ,
				CultureInfo.InvariantCulture
				//, DateTimeStyles.None
				);
		}


	}
}
