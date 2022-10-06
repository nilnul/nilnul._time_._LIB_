using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time_._lex_.phrase_
{
	/// <summary>
	/// year in two digits, such as 22, NOT in four digits as 2022.
	/// </summary>
	/// <remarks>
	/// as we are dealing with time, not datetime,  the frational seconds is in arbitrary precision. We need mantissa after decimal point.
	/// </remarks>
	public interface IYrInTwoDigits
	{
	}
}
