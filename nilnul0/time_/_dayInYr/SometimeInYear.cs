using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.time
{

	/// <summary>
	/// this denotes one day in a year. So this is a variable with constraints, a random with no distribution but a scope, a value that's not literal.
	/// </summary>
	public partial class SometimeInYear:ExprI
		
	{
		public int year { get; set; }
		public SometimeInYear(int year)
		{
			this.year = year;
		}


	

	

		
	}
}
