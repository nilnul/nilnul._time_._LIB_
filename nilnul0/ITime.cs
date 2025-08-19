namespace nilnul
{
	/// why we use time to denote datetime, not just time of the day?
	/// <see cref="_time._date.ICalendar"/>, where year of date is determined by solar revolution, and day is determined by earth rotation. days of a year is not a whole number, nor a constant; and seconds of a day is not a whole number, nor a constant. To measure time out of solar system, we may need to redefine date, but we can keep timeOfDay if the time is measured not against solar|earth, but on somethign thing more objective|contextfree, such as the time a quantum revolves around a nucleus; we then need to regulate the day/year with the seconds defined by, for example, setting some day as some seconds.
	///
	/// day according to seconds is not a constant length of time;
	///
	/// <summary>
	/// set the 0 point; set the unit. regards this as <see cref="nilnul.geometry.linear_.gauged"/>
	/// </summary>
	/// <remarks>
	/// to measure time, we need a tool that is physically objective, invariant to different location and time. eg: it shall not change when astronauts bring it out of solar system or out of galaxy; otherwise, the sync between different locations such as earth and spaceship would be out of order.
	/// 
	/// In ancient times, we use astronomical methods:
	///		,day, but subject to suspicions that the rate at which Earth rotates is gradually slowing and also shows small-scale irregularities;
	///
	///		
	/// later we use incense|cigaretts,pendulum clock or flyweight in mechanical wrishwatch, but they subject to the earthen condition and wouldnot be constant when brought out of earth or solar system.
	///
	/// In the late 1940s, quartz crystal oscillator clocks could measure time more accurately than the rotation of the Earth. Metrologists also knew that Earth's orbit around the Sun (a year) was much more stable than Earth's rotation.
	/// 
	/// and more modernly we use:
	///		quartz crystal oscillator in electronical clock or computer.
	///		
	///Even the best mechanical, electric motorized and quartz crystal-based clocks develop discrepancies from environmental conditions; far better for timekeeping is the natural and exact "vibration" in an energized atom.
	///The frequency of vibration (i.e., radiation) is very specific depending on the type of atom and how it is excited.
	/// Most recently, atomic clocks have been developed that offer improved accuracy. Since 1967, the SI base unit for time is the SI second, defined as exactly "the duration of 9,192,631,770 periods of the radiation corresponding to the transition between the two hyperfine levels of the ground state of the caesium-133 atom" ( at rest and in the absence of electric and magnetic fields, free of any perturbation,  at a temperature of 0 K and at mean sea level).Radiation of this kind is one of the most stable and reproducible phenomena of nature. The current generation of atomic clocks is accurate to within one second in a few hundred million years.
	/// Since 1967, atomic clocks based on atoms other than caesium-133 have been developed with increased precision by a factor of 100. Therefore a new definition of the second is planned.
	/// </remarks>
	/// the days on the timeline is not evenly distributed, but stipulated by a central authority server.
	/// <seealso cref="System.DateTime"/>
	/// alias:
	///		time
	///		instant
	///			,time point
	///
	/// vs:
	///		<see cref="nilnul.geometry"/>, this is the first appliance of the tally relation embodied by real axis, before geometry which need this to describe curve as a moving point over time;
	public interface ITime
		:
		nilnul.ral_.ord_.IContinuum
	{

	}

}
