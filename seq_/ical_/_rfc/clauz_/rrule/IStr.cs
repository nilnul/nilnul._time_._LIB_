using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time.seq_.ical_._rfc.clauz_.rrule
{
	/*
	 * 
	 * stackoverflow.com/questions/38296679/icalendar-spec-rrule-multiple-times
 according to the RFC you SHOULD NOT define more than one RRULE (see https://www.rfc-editor.org/rfc/rfc5545#section-3.8.5.3)
	it SHOULD NOT be specified more than once.The recurrence set generated with multiple "RRULE" properties is undefined.


stackoverflow.com/questions/32575146/can-rrule-descirbe-an-event-that-occurs-at-two-specific-times-each-day

	While support for multiple RRULE was there in RFC2445, it has been removed from RFC5545 for lack of interoperability between calendar agents.


	So the behavior depends on the actual implementation and I do not know about Google Calendar API. Most libraries I know of do support multiple RRULE though, so you should give it a try.


	Again, if there is a pattern, you can also use BYSETPOS.



You can use multiple RRULE on Google Calendar but I do not recommend it. See the v3 API documentation -- recurrence[]. Pass an array of strings.

While Google Calendar will respect multiple RRULE, Apple Calendar currently will only use one. This means that anyone uses Apple Calendar on their laptop/phone (synced from Google Calendar) will not see all recurrences.

Also, even though Google Calendar will repeat the event correctly, the written description of repeats used in the UI only describes one RRULE.

eg. "Weekly on Thursday, until May 15, 2021", not "Weekly on Tuesday & Thursday, until May 15, 2021"

If you do care about generic calendar clients, you are running a risk:

most of the clients will not let you edit the event RRULEs fully,
quite a few clients will misinterpret the rule when displaying the event.
As a workaround, you may want to create 2 events and link them with a related-to property (https://www.rfc-editor.org/rfc/rfc5545#section-3.8.4.5 )	 
	 */
	/// <summary>
	/// 
	/// </summary>
	internal class IStr
	{
	}
}
