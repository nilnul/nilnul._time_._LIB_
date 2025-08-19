using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time_.datetime._lex_.phrase_.yr_
{
	/// <summary>
	/// fractional second is phrased as mantissa.
	/// eg:
	///		220815 005300.0012300
	///		220815005300_00123
	///			vs 220815005300_23, which shall be bigger.
	///				but according to using <see cref="nilnul.txt_._versioned.version_.idable_.IDecs"/> and <see cref="nilnul.txt_._versioned.version_.decs.Comparer"/>, 00123 would be bigger  than 23.
	///				"_" separated shall be compared by mantissa, whileas "." separated shall be, according to how we deal with dll versions, compared by ListOfInt. Or do we just mistakenly swap them? 
	///		220815005300s00123
	///		
	///	leading zero is significant.
	/// 
	/// </summary>
	/// <remarks>
	/// to avoid confusion with:
	///		list of ints
	///		c# 123_45 integer
	///	we might use <see cref="decimalSubsecond_.seP_.Lower"/>
	/// </remarks>
	/// alias:
	///		significant
	///			as leading zeros are important.
	/// 
	internal class IFloated:IYrInTwoDigits
	{
	}
}
