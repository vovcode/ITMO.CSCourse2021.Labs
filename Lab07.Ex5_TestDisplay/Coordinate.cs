﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07.Ex5_TestDisplay
{
	// Sample class that implements the IPrintable interface

	class Coordinate : IPrintable
	{
		private double x;
		private double y;

		public Coordinate()
		{
			x = 0.0;
			y = 0.0;
		}

		public Coordinate(double px, double py)
		{
			x = px;
			y = py;
		}

		public void Print()
		{
			Console.WriteLine("({0},{1})", x, y);
		}
	}
}
