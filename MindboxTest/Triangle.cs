namespace MindboxTest
{
	/// <summary>
	/// Класс треугольника
	/// </summary>
	public class Triangle : IFigure
	{
		public Triangle(double firstSide, double secondSide, double thirdSide)
		{
			FirstSide = firstSide;
			SecondSide = secondSide;
			ThirdSide = thirdSide;
		}

		private double firstSide;

		/// <summary>
		/// Первая сторона треугольника
		/// </summary>
		public double FirstSide
		{
			get => firstSide;
			set
			{
				if (value <= 0)
					throw new ArgumentException("Значение стороны треугольника не может быть меньше или равно 0");
				firstSide = value;
			}
		}

		private double secondSide;

		/// <summary>
		/// Вторая сторона треугольника
		/// </summary>
		public double SecondSide
		{
			get => secondSide;
			set
			{
				if (value <= 0)
					throw new ArgumentException("Значение стороны треугольника не может быть меньше или равно 0");
				secondSide = value;
			}
		}

		private double thirdSide;

		/// <summary>
		/// Третья сторона треугольника
		/// </summary>
		public double ThirdSide
		{
			get => thirdSide;
			set
			{
				if (value <= 0)
					throw new ArgumentException("Значение стороны треугольника не может быть меньше или равно 0");
				thirdSide = value;
			}
		}

		public double GetArea()
		{
			// проверка на прямоугольный треугольник
			// не особо поняла зачем определение на прямоугольный трегуольник, надо ли это было выносить в отдельное свойство для чего-то другого
			List<double> sides = new List<double> (3) { firstSide, secondSide, thirdSide }.OrderBy(item => item).ToList();
			if (Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2))
			{
				return sides[0] * sides[1] / 2;
			}
			else
			{
				double halfMeter = (firstSide + secondSide + thirdSide) / 2;
				return Math.Sqrt(halfMeter * (halfMeter - firstSide) * (halfMeter - secondSide) * (halfMeter - thirdSide));
			}
		}
	}
}
