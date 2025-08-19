namespace nilnul.time.seq_.ical_.rfc_
{
	/// <summary>
	/// eg:
	/// RRULE:FREQ=DAILY
	///		
	/// </summary>
	/// <remarks>
	///eg:
	///	RRULE:FREQ=DAILY
	///	EXDATE:20151225T173000Z
	/// </remarks>
	interface IDaily { }

	public class Daily
	{
		public string phrase8rrule() {
			return "RRULE:FREQ=DAILY";
		}
	}

}
