namespace nilnul._time.clock_
{
	/// <summary>
	/// the TimeSpan can be used to stand for time-of-day.
	/// As of .Net 3.5, MSDN documents that "The TimeSpan structure can also be used to represent the time of day, but only if the time is unrelated to a particular date.". In other words, this is exactly the solution to the proposed question.
	/// </summary>
	class TimeSpanX
	{
		//TimeSpan timeSpan = new TimeSpan(2, 14, 18);
		//Console.WriteLine(timeSpan.ToString());     // Displays "02:14:18".
	}
}
