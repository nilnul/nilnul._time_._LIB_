using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time_.datetime.split.phrase_
{
	/*
		
	 
	 */
	/// <summary>
	/// 
	/// </summary>
	public class TrimEnd
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="obj"></param>
		/// <returns>
		/// </returns>
		public  string phrase(DateTime obj)
		{
			var ticks=phrase_.SevenDigits.Singleton.phrase(obj);
			var ticksTrimmed=ticks.TrimEnd('0');
			return ticksTrimmed;
		}




		static public TrimEnd Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<TrimEnd>.Instance;
			}
		}


	}
}
