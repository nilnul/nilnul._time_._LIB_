using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time_.datetime.bound_.day.phrase_.seP_.hyphen_
{
	static public class _YyyyMmDdX 
	{
		public const char SEP = '-';
		static public string Phrase(DateTime obj)
		{
			return obj.ToString($"yyyy{SEP}MM{SEP}dd");
		}
	}
}
