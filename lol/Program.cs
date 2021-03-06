//
//  Program.cs
//
//  Author:
//       student <>
//
//  Copyright (c) 2014 student
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
using System;

namespace NOD
{
	class MainClass
	{
		public static int GCD(int a, int b)

		{

			if (a == 0) return b;

			if (b == 0) return a;

			if (a == b) return a;

			if (a == 1 || b == 1) return 1;

			if ((a % 2 == 0) && (b % 2 == 0)) 

				return 2 * GCD(a / 2, b / 2);

			if ((a % 2 == 0) && (b % 2 != 0)) 

				return GCD(a / 2, b);

			if ((a % 2 != 0) && (b % 2 == 0)) 

				return GCD(a, b / 2);

			return GCD(b, (int)Math.Abs(a - b));

		}

		public static void Main() 

		{

			int x = 70;

			int y = 105;

			int gcd = GCD(x,y);

			Console.WriteLine("НОД({0},{1})={2}", x, y, gcd);

		}
	}
}