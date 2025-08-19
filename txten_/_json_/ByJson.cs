//using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Runtime.CompilerServices;

namespace nilnul.time.txten_._json_
{
	/// <summary>
	/// <see cref="nilnul.time_.datetime.lex_._rfc3339.phrase_.ByJsonConvert"/>
	/// </summary>
	/// <remarks>
	/// conforms to <see cref="txten_.rfc3339"/>
	/// </remarks>
	/// 
	public class ByJson
		: time_.datetime.PhraseA
		,
		time._phrase_.OfTimeI
	{

		//static public readonly JsonSerializer serializer = new JsonSerializer();

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public string Txten(DateTime obj) {
			return JsonSerializer.Serialize(DateTime.Now);//Unlike XmlConvert will have have escaped double-quotes on each end.

		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override string phrase(DateTime obj)
		{
			return Txten(obj);

		}


		static public ByJson Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<ByJson>.Unison;
			}
		}

	}
}
