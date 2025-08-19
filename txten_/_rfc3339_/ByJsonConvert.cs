//using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
//using System.Text.Json;

namespace nilnul.time_.datetime.lex_._rfc3339.phrase_
{
	/// <summary>
	/// <see cref="nilnul.time.txten_._json_.ByJson"/>
	/// </summary>
	public class ByJsonConvert
		: datetime.PhraseA
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override string phrase(DateTime obj)
		{

			return nilnul.time.txten_._json_.ByJson.Txten(obj);
			//return JsonConvert.SerializeObject(DateTime.Now);//Unlike XmlConvert will have have escaped double-quotes on each end.

		}


		static public ByJsonConvert Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<ByJsonConvert>.Unison;
			}
		}

	}
}
