using System;

namespace MonteCarlo
{
    public struct Coordinate
    {
        private double x, y;
        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }
        public Coordinate(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public Coordinate(Random random)
        {
            this.x = random.NextDouble();
            this.y = random.NextDouble();
        }
        public double Hypotenuse()
        {
            return Math.Sqrt(Math.Pow(this.x, 2) + Math.Pow(this.Y, 2));
        }
    }
}
