namespace nilnul.time
{
	/// <summary>
	/// the timepoint moves from one time|instant to another;
	/// </summary>
	/// <remarks>
	/// the border has no impact on the deviation.
	/// </remarks>
	/// alias:
	///		elapse
	///		deviation
	///			similar to <see cref="IDuration"/>
	///		diversion
	///		
	///		stray
	///		departure
	///		displace from the origin
	///		
	///		<see cref="System.TimeSpan"/>
	///		offset
	///		slack
	///		discrepancy
	///			,<see cref="IDuration"/>
	///		drift
	///		delta
	///			,a-b, or b-a
	///		diff, which can mean a-b as well as b-a
	public interface IElapse

		:
		co.IDifference
		,
		 betwixt.content.IDisplace
		,
		grad.IDiscern
		,
		grad.IDeviation_bySignedMeasure
		

	{ }
}
