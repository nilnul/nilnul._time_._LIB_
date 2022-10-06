using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time_.datetime._lex_
{
	public interface PhraseI:nilnul.obj.PhraseI<DateTime>
	{
	}
	public abstract class PhraseA : PhraseI
	{
		public abstract string phrase(DateTime obj);
		public string phrase() {
			return phrase(DateTime.UtcNow);
		}
	}
}
