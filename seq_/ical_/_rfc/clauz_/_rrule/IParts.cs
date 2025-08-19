namespace nilnul.time.seq_.ical_._rfc.clauz_._rrule
{
	/// <summary>
	/// Each rule part is defined by a NAME=VALUE pair. Individual rule parts MUST only be specified once.
	/// according to the syntax, the trailing ';' is disallowed;
	/// but in fact, the trailing ';' does no harm;
	/// </summary>
	/// <remarks>
	///The rule parts are not ordered in any particular sequence. but to ensure backward compatibility with applications that pre-date this revision of iCalendar, the FREQ rule part MUST be the first rule part specified in a RECUR value.
	///it seems some part must be in uppercase. for example:
	///	FREQ=Daily would throw exception in goole calendar api.
	/// </remarks>
	interface IParts { }
}
