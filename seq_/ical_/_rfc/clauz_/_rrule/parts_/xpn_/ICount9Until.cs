using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time.seq_.ical_._rfc.clauz_._rrule.parts_.xpn_
{
	/*
	stackoverflow.com/questions/33551588/rrule-rfc-5545-until-and-count
 
	Recurrence Rule


   Formal Definition: The value type is defined by the following
   notation:

     recur      = "FREQ"=freq *(

                ; either UNTIL or COUNT may appear in a 'recur',
                ; but UNTIL and COUNT MUST NOT occur in the same 'recur'


When I check libraries that implement rrule generator and parsing, there is no validation that make sure that the the COUNT and UNTIL are not in the same recur.
	 
	 */
	/*
 google calendar would respond:
	GoogleApiException:
		The service calendar has thrown an exception. HttpStatusCode is BadRequest.
		Invalid recurrence rule.

	 */
	/// <summary>
	/// 
	/// </summary>
	internal class ICount9Until
	{
	}
}
