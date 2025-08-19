namespace nilnul._time.clock_
{
	/// <summary>
	/// after <see cref="IDusk"/>, but before the coming <see cref="IDawn"/>.
	/// Hence this is past 24:00. eg: it might be:
	///		[19:30 ,24:00 +  6:20)
	///		=[19:30 ,30:20)
	///		, or :
	///		[19:30, 24:00) union with the next day: [0, 6:20)
	/// </summary>
	/// alias:
	///		nocturnal
	///		
	interface INight { }


}
