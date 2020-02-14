using System;
using System.Drawing;
//
namespace Fractals
{
    internal static class DragonFractalTask
    {
        public static void DrawDragonFractal(Pixels pixels, int iterationsCount, int seed)
        {
            Random rnd = new Random(seed);
            double x = .777, y = 0;
            bool transform = false;

            pixels.SetPixel(x, y);

            for (int i = 0; i < iterationsCount; i++)
            {
                transform = rnd.Next() % 2 != 0;
                if (!transform)
                    MainTransform(pixels, ref x, ref y);
                else
                    OtherTransform(pixels, ref x, ref y);
            }
        }

        private static void OtherTransform(Pixels pixels, ref double x, ref double y)
        {
            double xTmp = ((x * Math.Cos(90 * Math.PI / 180)) -
                           (y * Math.Sin(90 * Math.PI / 180))) / Math.Sqrt(2) + 1;
            y = ((x * Math.Sin(135 * Math.PI / 180)) +
                 (y * Math.Cos(135 * Math.PI / 180))) / Math.Sqrt(2);
            x = xTmp;
            pixels.SetPixel(x, y);
        }

        private static void MainTransform(Pixels pixels, ref double x, ref double y)
        {
            double xTmp = ((x * Math.Cos(45 * Math.PI / 180)) -
                           (y * Math.Sin(45 * Math.PI / 180))) / Math.Sqrt(2);
            y = ((x * Math.Sin(45 * Math.PI / 180)) +
                 (y * Math.Cos(45 * Math.PI / 180))) / Math.Sqrt(2);
            x = xTmp;
            pixels.SetPixel(x, y);
        }
    }
}
