namespace nilnul.time.seq_.ical_._rfc.clauz_._rrule.part_
{
	/// <summary>
	/// eg:
	/// BYHOUR=11,18
	///		,which means at hour 11, as well as at hour 18;
	///
	/// eg:
	///		BYDAY=MO,FR;
	/// </summary>
	/// <remarks>
	/// Some 'expand' the number of days and some 'limit' the number of days.
	/// If multiple BYxxx rule parts are specified, then after evaluating the specified FREQ and INTERVAL rule parts, the BYxxx rule parts are applied to the current set of evaluated occurrences in the following order: BYMONTH, BYWEEKNO, BYYEARDAY, BYMONTHDAY, BYDAY, BYHOUR, BYMINUTE, BYSECOND and BYSETPOS; then COUNT and UNTIL are evaluated.
	///
	/// Limit means that the possible repeat dates are limited by the “BY” specification.  Expand means that the possible repeat dates are expanded by the BY values. 
	/// 
	/// </remarks>
	/// alias:
	///		constrained
	///		subject to
	///		at
	///		by
	enum By {


		/// <summary>
		///  Every other month on the first and last Sunday of the month for 10   occurrences:
		///  DTSTART;TZID=America/New_York:19970907T090000
		///  RRULE:FREQ=MONTHLY;INTERVAL=2;COUNT=10;BYDAY=1SU,-1SU
		///  ==> (1997 9:00 AM EDT) September 7,28
		///  (1997 9:00 AM EST) November 2,30
		///  (1998 9:00 AM EST) January 4,25;March 1,29
		///  (1998 9:00 AM EDT) May 3,31
		/// </summary>
		DAY
			,
		WEEKNO
			,
		MONTH
			,
		SETPOS

	}
}
