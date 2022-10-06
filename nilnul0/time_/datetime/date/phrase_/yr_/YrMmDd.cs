using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time_.datetime.phrase_
{
	/// <summary>
	/// by default, in naming the partition folder of nilnul.dev Repo, we use the leading two digits to denote year.
	/// eg:
	///		201210/ means Year 20+2k, Month 12 or december, Day10.
	///		2012 means year 20+2k, month12 or December.
	///		20 means year 20+2k=2020.
	///		0y201210 mean year 2012, month 10.
	///			0y has up to four digits followed to be recognized as year.
	///	<see cref="nameof(nilnul.txt_._vered.ver_.SingleLetterAmong)"/>
	/// </summary>
	public class YyMmDd : nilnul.time_.datetime.PhraseA
	{
		private string _sep;

		public string sep
		{
			get { return _sep; }
			set { _sep = value; }
		}

		public YyMmDd(string sep)
		{
			_sep = sep;
		}
		public YyMmDd():this("")
		{

		}

		public override string phrase(DateTime obj)
		{
			return obj.ToString($"yy{_sep}MM{_sep}dd");
		}


		static public YyMmDd Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<YyMmDd>.Instance;
			}
		}


	}
}
