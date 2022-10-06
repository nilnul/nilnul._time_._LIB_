using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time_.datetime.phrase_
{
	public class HhMmSs : nilnul.time_.datetime.PhraseA
	{
		public override string phrase(DateTime obj)
		{
			return obj.ToString("HHmmss" );
		}




		static public HhMmSs Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<HhMmSs>.Instance;
			}
		}


	}
}
