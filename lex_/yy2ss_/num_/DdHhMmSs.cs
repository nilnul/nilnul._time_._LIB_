using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time_.datetime.phrase_
{
	public class DdHhMmSs : nilnul.time_.datetime.PhraseA
	{
		public override string phrase(DateTime obj)
		{
			return obj.ToString("ddTHHmmss" );
		}





		static public DdHhMmSs Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<DdHhMmSs>.Instance;
			}
		}



	}
}
