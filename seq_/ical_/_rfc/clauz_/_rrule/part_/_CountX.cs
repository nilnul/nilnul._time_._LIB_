namespace nilnul.time.seq_.ical_._rfc.clauz_._rrule.part_
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// </remarks>
	/// cannot be together with <see cref="IInterval"/>? incorrect, they can
	static public class _CountX
	{
		public const string KEY = "COUNT";


		static public string _Texfy_0count(int count =1) {
			return nilnul.obj.attr._PhraseX.Phrase(KEY, count);
		}

	}
}
