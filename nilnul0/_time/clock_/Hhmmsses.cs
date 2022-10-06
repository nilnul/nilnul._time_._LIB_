using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._time.clock_
{
	/// <summary>
	/// two digit num for hours.
	///		the num can be more than 24, such as 35.
	///	two digit num for minutes
	///		the num can be more than 60, such as 99.
	///			if minutes are le 100, we use hour to express the 60, and let the minut to denote the remained 40.
	///	the remaining is all for seconds.
	///		seconds can be a two digit num, which can exceed 60, such as 99.
	///		
	///		in addtion to the num, we can have split second.
	///		So the seconds is in free form, it can be a decimal mantissa such as 20.2512, or it can be a real number, or a fraction such 1/2.
	///			generally we adopt the decimal mantissa, and when "." is not apt, we use "_", such that we have "20_5", "20_36". Note "20_36" means "20.36", so it is less than "20_5" 
	/// </summary>
	public interface ISpan {

	}
}
