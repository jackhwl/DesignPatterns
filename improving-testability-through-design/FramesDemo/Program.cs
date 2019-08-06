using System;
using Models;
using Models.Common;

namespace FramesDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			Frame frame = new Frame();
			frame.Length = 3.0m;
			frame.Width = 4.0m;

			TryAddCircle(frame, 1.5m, 2.0m, 1.1m);
			TryAddCircle(frame, 2.0m, 2.0m, 1.1m);
			TryAddCircle(frame, 1.5m, 2.0m, 1.1m);

			frame.Draw();

			Console.ReadLine();
		}

		private static ICircle TryAddCircle(Frame frame, decimal x, decimal y, decimal radius)
		{
			ICircle circle = new Circle()
			{
				X = x,
				Y = y,
				Radius = radius
			};

			if (frame.TryAddCircle(circle))
				Console.WriteLine("Add circle at ({0}, {1}, R{2}", x, y, radius);
			else
				Console.WriteLine("Could not Add circle at ({0}, {1}, R{2}", x, y, radius);

			return circle;
		}
	}
}
