using System;

namespace GEAR1
{
	public class Gear1
	{
		static Int32 MIN_T = 12, MAX_T = 20;
		static Int32 MIN_P = 3, MAX_P = 6;

	    public Int32 st = 0, pt = 0, rt = 0, num_p = 0;
		public Double module = 0.0, dia = 0.0;
		Random rand;
		public Gear1(Double mod)
		{
			module = mod;
			rand = new Random();
		}

		public void create()
        {

            while (1 > 0)
            {
				st = rand.Next(MIN_T, MAX_T) + MIN_T;
				pt = rand.Next(MIN_T, MAX_T) + MIN_T;
				
				num_p = rand.Next(MIN_P, MAX_P) + MIN_P;//
				num_p = 4;

				if (check(1) && check(2))
					break;
			}

			rt = st + 2 * pt;

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
					if (Math.Abs(module*rt - dia) <= 20.0)
						return true;
					else
						return false;

				default:
					return false;
            }
        }

		public void show()
        {
			Console.WriteLine("SUN1 TEETH: {0}", st);
			Console.WriteLine("PLANET1 TEETH: {0}", pt);
			Console.WriteLine("RING1 TEET: {0}", rt);
			Console.WriteLine("NUMBER OF PLANETS: {0}", num_p);
		}
	}
}
