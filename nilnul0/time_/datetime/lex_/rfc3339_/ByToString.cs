//using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time_.datetime.lex_.rfc3339_
{
	public class ByToString
		: datetime.LexA
	{
		public override string phrase(DateTime datetime)
		{

			return datetime.ToUniversalTime().ToString("yyyy-MM-dd'T'HH:mm:ssZ");
		}

		//public  string phrase(DateTimeOffset datetime)
		//{
		//	return phrase(datetime.ToUniversalTime().DateTime);
		//}

		public override DateTime parse(string x)
		{
			return DateTime.Parse(x);
		}

		static public ByToString Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<ByToString>.Unison;
			}
		}

	}
}
