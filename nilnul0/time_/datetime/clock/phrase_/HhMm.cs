using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time_.datetime.phrase_
{/// <summary>
/// 24hours a day
/// </summary>
	public class HhMm : nilnul.time_.datetime.PhraseA
	{
		public override string phrase(DateTime obj)
		{
			return obj.ToString("HHmm" );
		}




		static public HhMm Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<HhMm>.Instance;
			}
		}


	}
}
