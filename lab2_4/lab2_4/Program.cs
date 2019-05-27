using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_4
{
	class Program
	{
		static double FunA(int i)
		{
			double res = 0;
			int x;
			for (x = i; x < i + 8; x++)
			{
				res += Math.Abs(Math.Sin(2 * x - 1.5) + 3 * Math.Sin(Math.Pow(x, 2)) + 2.38);

			}
			return res;
		}
		static double FunB(int i)
		{
			double res = 1;
			int x;
			for (x = i; x < i + 5; x++)
			{
				res *= Math.Abs(Math.Sin(2 * x - 1.5) + 3 * Math.Sin(Math.Pow(x, 2)) + 2.38);

			}
			return res;

		}

		static double Z(double a, double b)
		{
			return b * Math.Tan(a);
		}

		static void Main(string[] args)
		{
			int i = 7;
			double a = FunA(i);
			double b = FunB(i);
			Console.WriteLine("Z = " + Z(a, b));
		}
	}
}

