namespace nilnul.time.set
{
	/// duration must be defined on a collection.
	/// <summary>
	/// a time point moves across a distance to another time|instant;
	/// </summary>
	/// <remarks>
	/// a measure for the bound;
	/// how long is the time. This is a nonneg value in line with nilnul.geometry.linear
	/// ;
	/// this is Lebesgue measure, not the trivia (all 0s) measure.
	/// </remarks>
	/// alias:
	///		period
	///			of time
	///			
	///		length
	///		measure
	///		lebesgue
	///	vs:
	///		span,which can be neg;
	///			
	public interface ILebesgue
		:
		//tend.IMeasure
		nilnul.collective.IMeasure
	{

	}
}
