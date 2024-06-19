using System;

namespace Lab_05_homework_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Point3D point = new Point3D(20, 30, 40);
            Console.WriteLine("Point before translation: " + point);

            point.Translate(56, -53, 59);
            Console.WriteLine("Point after translation: " + point);
        }
    }

    struct Point3D
    {
        public int CoordinateX { get; set; }
        public int CoordinateY { get; set; }
        public int CoordinateZ { get; set; }

        public Point3D(int coordinateX, int coordinateY, int coordinateZ)
        {
            CoordinateX = coordinateX;
            CoordinateY = coordinateY;
            CoordinateZ = coordinateZ;
        }

        public void Translate(int dX, int dY, int dZ)
        {
            CoordinateX += dX;
            CoordinateY += dY;
            CoordinateZ += dZ;
        }

        public override string ToString()
        {
            return $"(X: {CoordinateX}, Y: {CoordinateY}, Z: {CoordinateZ})";
        }
    }
}