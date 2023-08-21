namespace Tasks_Mindbox.Task1
{
    public class Circle : IShape
    {
        public double Radius { get; init; }
        public Circle(double radius)
        {
            Radius = radius;
        }


        public double CalculateArea()
        {
            return 2*Math.PI*Radius*Radius;
        }
    }
}
