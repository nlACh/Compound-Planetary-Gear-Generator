using System;
using GEAR1;

namespace GEAR2
{
	public class Gear2
	{
		static Int32 MIN_T = 12, MAX_T = 20;

		public Int32 st = 0, pt = 0, rt = 0, num_p = 0;
		Double module = 0.0;
		Double module1 = 0.0; // Module of gear 1
		Int32 s1, p1, r1; // Sun and planet of gear 1

        Random rand;

		public Gear2(Gear1 gear)
		{
			num_p = gear.num_p;
			s1 = gear.st;
			p1 = gear.pt;
			r1 = gear.rt;
			module1 = gear.module;
			rand = new Random();
			Console.WriteLine("Got from GEAR1: sun{0}, planet{1}, ring{2}, module{3}", s1, p1, r1, module1);
		}

		public void create()
        {
			while (1 > 0)
			{
				st = rand.Next(MIN_T, MAX_T) + MIN_T;
				pt = rand.Next(MIN_T, MAX_T) + MIN_T;
				rt = 2 * pt + st;
				module = module1 * (s1 * 1.0 + p1 * 1.0) / (st * 1.0 + pt * 1.0);

				if (check(1) && check(2) && check(3))
					break;

			}
			//show();
		}

		Boolean check(Int16 j)
        {
            switch (j)
            {
				case 1:
					Double d = (st + pt) / num_p;
					if (Math.Ceiling(d) == Math.Floor(d))
						return true;
					else
						return false;

				case 2:
					if (st % 2 == 0 && pt % 2 == 0)
						return true;
					else
						return false;

				case 3:
					if (module <= module1 && rt <= r1)
						return true;
					else
						return false;

				default: return false;
            }
        }

		public void show()
		{
			Console.WriteLine("SUN2 TEETH: {0}", st);
			Console.WriteLine("PLANET2 TEETH: {0}", pt);
			Console.WriteLine("RING2 TEETH: {0}", rt);
			Console.WriteLine("NUMBER OF PLANETS: {0}", num_p);
			Console.WriteLine("MODULE OF OUTPUT: {0}", module);
		}
	}
}
