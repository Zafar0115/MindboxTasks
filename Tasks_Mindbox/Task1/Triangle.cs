namespace Tasks_Mindbox.Task1
{
    public class Triangle : IShape
    {
        public double SideA { get; init; }
        public double SideB { get; init; }
        public double SideC { get; init; }
        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }


        public double CalculateArea()
        {
            double p = (SideA + SideB + SideC) / (2 * 1.0);
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }


        public bool CheckIfTriangle()
        {
            double[] sides = { SideA, SideB, SideC };
            Array.Sort(sides);
            return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
        }
    }
}
