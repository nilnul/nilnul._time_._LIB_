namespace nilnul.time.seq_.ical_._rfc.clauz_._rrule.part_
{
	///icalendar.org/iCalendar-RFC-5545/3-3-10-recurrence-rule.html
	/// <summary>
	/// The UNTIL rule part defines a DATE or DATE-TIME value that bounds the recurrence rule in an inclusive manner. 
	/// </summary>
	/// <remarks>
	///If the value specified by UNTIL is synchronized with the specified recurrence, this DATE or DATE-TIME becomes the last instance of the recurrence.
	///The value of the UNTIL rule part MUST have the same value type as the "DTSTART" property.
	///		Furthermore, if the "DTSTART" property is specified as a date with local time, then the UNTIL rule part MUST also be specified as a date with local time. (only in this case can it be date local;)
	///		If the "DTSTART" property is specified as a date with UTC time or a date with local time and time zone reference, then the UNTIL rule part MUST be specified as a date with UTC time.
	///		
	/// In the case of the "STANDARD" and "DAYLIGHT" sub-components the UNTIL rule part MUST always be specified as a date with UTC time. If specified as a DATE-TIME value, then it MUST be specified in a UTC time format.
	/// </remarks>
	/// eg:
	///		UNTIL=20000131T090000Z;
	interface IUntil { }
}
