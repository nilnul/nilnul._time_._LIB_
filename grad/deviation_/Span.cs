using nilnul.num;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time
{
	/// <summary>
	/// <see cref="nameof(nilnul.time.bound.IMetric)"/>
	/// see nilnul.geometry.linear.Span (not Grad).
	/// </summary>
	/// <remarks>
	/// alias:
	///		duration
	///			duration is always nonneg
	/// </remarks>
	public interface ISpan
		:nilnul.obj.IMetric
		
		
	{

	}
	/// <summary>
	/// the length of timeBound
	/// 
	/// </summary>
	/// <remarks>
	/// aliase:
	///		Dif
	///		duration
	///	vs:
	///		Bound
	///			bound has two time point, or border.
	///			span has no fixed border; span is only the lenght/width of a bound.
	///		Clock
	///			clock is used to denote timeOfDay
	///			span can be used to denote timeOfDay also, if span is le 24hours.Span can also span across severual days, even months.
	///			
	///			clock is the ordinal number of hours, such as the 7th hour.
	///			span is the cardinal number of hours, such as 7 hours.
	///
	///			clock's unit is counting since the end of the previous hour.
	///			span is counting from a middle of an hour into the middle of another hour.
	/// 
	///			the pair are different in meaning, not in intrinsic definition. so clock is normalized span.
	/// </remarks>
	public class Span
	//:
	//nilnul.obj.Box<nilnul.num.RealI>

	{
		private nilnul.num.RealI _quantity;

		public nilnul.num.RealI quantity
		{
			get { return _quantity; }
			set { _quantity = value; }
		}

		private nilnul.time.seg._measure.UnitI _unit;

		public nilnul.time.seg._measure.UnitI unit
		{
			get { return _unit; }
			set { _unit = value; }
		}

		public Span(RealI val, time.seg._measure.UnitI unit)
		{
			this._quantity = val;
			this._unit = unit;
		}

		public string phrase_day2sec(uint digitsAftDot4seconds=0)
		{
			RealI remainder;
			System.Numerics.BigInteger days;
			 (days, remainder) = nilnul.num.real.co_.divisible.div_._RetFlooredX.Div(
				_quantity,
				24*60*60
			);

			var (hours, hourRemainder1) = nilnul.num.real.co_.divisible.div_._RetFlooredX.Div(
				remainder,
				60*60
			);

			var (minutes, minuteRemainder1) = nilnul.num.real.co_.divisible.div_._RetFlooredX.Div(
				hourRemainder1,
				60
			);

			return $"{days}Days{hours}Hours{minutes}Minutes{nilnul.num.real.to_._RadixX._Clamp2Dec_DigitsAftDot(minuteRemainder1, digitsAftDot4seconds)}seconds";



		}
	}

}
