using ConsoleApp.ClassesDemo.Interfaces;

namespace ConsoleApp.ClassesDemo.Classes.ShapeDemo
{
    public class Rectangle : Polygon, I2DShape
    {
        public Rectangle(int width, int length)
        {
            Width = width;
            Length = length;
        }
        public int Length { get; set; }
        public override double Area()
        {
            return Width * Length;
        }

        public double Perimeter()
        {
            return 2 * Length + 2 * Width;
        }

        public override string GetShapeName()
        {
            return "";
        }
    }
}
