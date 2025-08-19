using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._time.date.phrase_.sep_
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// </remarks>
	public class Hyphenated
		:Separatored
	{

	
		public Hyphenated() : base('-')
		{
		}
	
	

		static public Hyphenated Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Hyphenated>.Instance;
			}
		}

	}
}
