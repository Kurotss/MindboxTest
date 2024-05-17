namespace MindboxTest
{
	/// <summary>
	/// Класс круга
	/// </summary>
	public class Circle : IFigure
	{
		public Circle(double radius)
		{
			Radius = radius;
		}

		private double radius;

		/// <summary>
		/// Радиус круга
		/// </summary>
		public double Radius
		{
			get => radius;
			set
			{
				if (value <= 0)
					throw new ArgumentException("Значение радиуса круга не может быть меньше или равно 0");
				radius = value;
			}
		}

		public double GetArea() => Math.PI * Math.Pow(Radius, 2);
	}
}
