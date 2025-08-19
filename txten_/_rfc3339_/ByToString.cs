//using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time_.datetime.lex_._rfc3339.phrase_
{
	public class ByToString
		: datetime.PhraseA
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override string phrase(DateTime datetime)
		{

			return datetime.ToString("yyyy-MM-ddTHH:mm:ssZ");
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
