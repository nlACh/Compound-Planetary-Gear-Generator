using System;
using GEAR1;
using GEAR2;

namespace Compound_GEAR_GEN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Gear1 g1;
            Gear2 g2;

            Double mod1 = 0.0, ratio = 0.0, res;

            try
            {
                Console.WriteLine("Enter the module for Gear 1");
                mod1 = Double.Parse(Console.ReadLine());

                Console.WriteLine("Enter desired ratio");
                ratio = Double.Parse(Console.ReadLine());

            }
            catch(Exception e)
            {
                Console.WriteLine("ERROR: {0}", e);
            }
            
            //Console.WriteLine("GEAR1");
            g1 = new Gear1(mod1);

            do
            {
                g1.create();

                //Console.WriteLine("GEAR2");
                g2 = new Gear2(g1);
                g2.create();

                res = makeGearRatio(g1, g2);
            } 
            while (Math.Abs(ratio - res) >= 5.0);
            Console.WriteLine("GEAR1");
            g1.show();
            Console.WriteLine("GEAR2");
            g2.show();
            Console.WriteLine("FINAL RATIO: {0}", res);
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

        }

        static public Double makeGearRatio(Gear1 g1, Gear2 g2)
        {
            Int32 R2 = g2.rt, P2 = g2.pt;
            Int32 R1 = g1.rt, P1 = g1.pt, S1 = g1.st;
            Double ratio = (((R2*1.0 - ((R1 / P1*1.0) * P2)) / R2) * (S1 / (R1*1.0 + S1*1.0)));
            //Console.WriteLine("RATIO: {0}", ratio);
            return (1/ratio);
        }
    }
}
