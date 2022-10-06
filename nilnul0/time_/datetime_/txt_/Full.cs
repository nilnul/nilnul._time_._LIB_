using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time_.datetime_.txt_
{
	public class Full : TxtI
	{
		public DateTime parse(string s)
		{
			return nilnul.time_.datetime_.txt_._FullX.Parse(s);

		}

		public string phrase(DateTime obj)
		{
			return nilnul.time_.datetime.phrase_.Full.Singleton.phrase(obj);
		}

		static public Full Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Full>.Instance;
			}
		}

	}
}
