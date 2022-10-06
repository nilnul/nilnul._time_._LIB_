using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time_.datetime.phrase_
{
	public  class Iso:nilnul.time_.datetime.PhraseA
	{
		

		public override string phrase(DateTime src)
		{

			return src.ToUniversalTime().ToString("yyyy:MM:ddTHH:mm:ssZ");

		}

		static public string ToLocalWithOffset(DateTime time)
		{
			return time.ToLocalTime().ToString(
				"yyyy:MM:dd HH:mm:ss zzz"
			);

		}
		static public string ToLocalWithOffset()
		{
			return ToLocalWithOffset(DateTime.Now);

		}





		public string to() {
			return phrase(DateTime.Now);
		}


		static public Iso Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Iso>.Instance;
			}
		}


	}
}
