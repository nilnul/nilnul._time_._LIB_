namespace nilnul.time.borel_.dwelt_
{
	/// <summary>
	/// eg:
	///		countable union of <see cref="IConsecutive"/>.
	///	; the countable cannot be 0, as when the countable is 0, this is empty.
	///		
	/// </summary>
	/// <remarks>
	/// this reduces the ambiguity of whether <see cref="borel_.IUnConsecutive"/> shall include <see cref="borel_.IEmpty"/>
	/// </remarks>
	public interface IUnConsecutive:
		time.borel_.IDwelt
		,
		time.borel_.IUnConsecutive
	
	{
	}


}
