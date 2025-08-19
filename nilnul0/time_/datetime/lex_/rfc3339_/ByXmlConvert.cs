//using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace nilnul.time_.datetime.lex_.rfc3339_
{
	public class ByXmlConvert
		: datetime.LexA
	{
		public override string phrase(DateTime datetime)
		{
			return XmlConvert.ToString(datetime.ToUniversalTime(), XmlDateTimeSerializationMode.Utc);
			//return XmlConvert.ToString(datetime);
		}

		
		public override DateTime parse(string x)
		{
			return XmlConvert.ToDateTime(x, XmlDateTimeSerializationMode.Utc);
		}

		static public ByXmlConvert Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<ByXmlConvert>.Unison;
			}
		}

	}
}
