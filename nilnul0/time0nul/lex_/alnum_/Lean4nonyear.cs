using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace nilnul.time0nul.lex_.alnum_
{
	/// <summary>
	/// year in at least 3 digits; other parts are collapsible;
	/// </summary>
	public class Lean4nonyear :
		nilnul.time0nul.PhraseI
		,
		nilnul.time0nul.ParseI
	{

		public  string phrase(DateTime? obj)
		{
			return obj is null?"": nilnul.time_.datetime.lex_.alnum_.NonyearCollapse.Singleton.phrase(obj.Value);
		}

		public DateTime? parse(string txt)
		{
			try
			{
				return nilnul.time_.datetime.lex_.alnum_.NonyearCollapse.Singleton.parse(
					txt
				);
			}
			catch (Exception x)
			{
				Trace.TraceError(
					new XElement("time5alnum",
						$"error when parsing alnum { new XElement("txt", txt) } as time: {x.ToString()}"
					).ToString()
				);
				return null;
			}
		}


		static public Lean4nonyear Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Lean4nonyear>.Instance;
			}
		}

	

	}
}
