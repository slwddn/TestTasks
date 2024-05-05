using System.Numerics;

namespace Task4;

class Task2
{
    static int Main(string[] args)
    {
        if (args.Length < 2)
        {
            Console.WriteLine("Неверно указаны аргументы >:(");
            return 1;
        }

        var circleCoordinatesFilePath = args[0];
        var pointsCoordinatesFilePath = args[1];

        var circle = GetCircle(circleCoordinatesFilePath);
        var points = GetPoints(pointsCoordinatesFilePath);

        GetPointPosition(circle, points);

        return 0;
    }

    private static Circle GetCircle(string filePath)
    {
        var lines = File.ReadAllLines(filePath);

        var splitted = lines[0].Split(' ');
        var circleCenterX = BigRational.Parse(splitted[0]);
        var circleCenterY = BigRational.Parse(splitted[1]);
        var radius = int.Parse(lines[1]);

        var circleCenter = new BigRationalPoint(circleCenterX, circleCenterY);
        var circle = new Circle(circleCenter, radius);

        return circle;
    }

    private static BigRationalPoint[] GetPoints(string filePath)
    {
        var lines = File.ReadAllLines(filePath);
        var convertedPoints = new BigRationalPoint[lines.Length];

        for (var i = 0; i < lines.Length; i++)
        {
            var splitted = lines[i].Split(' ');
            var pointX = BigRational.Parse(splitted[0]);
            var pointY = BigRational.Parse(splitted[1]);

            var point = new BigRationalPoint(pointX, pointY);
            convertedPoints[i] = point;
        }

        return convertedPoints;
    }

    static void GetPointPosition(Circle circle, BigRationalPoint[] convertedPoints)
    {
        foreach (var point in convertedPoints)
        {
            var x = point.X - circle.Center.X;
            var y = point.Y - circle.Center.Y;
            
            var distanceSqr = x * x + y * y;
            var radiusSqr = circle.Radius * circle.Radius;

            if (distanceSqr == radiusSqr)
            {
                Console.WriteLine(0);
            }

            if (distanceSqr < radiusSqr)
            {
                Console.WriteLine(1);
            }

            if (distanceSqr > radiusSqr)
            {
                Console.WriteLine(2);
            }
        }
    }

    class BigRationalPoint
    {
        private BigRational _x;
        private BigRational _y;

        public BigRationalPoint(BigRational x, BigRational y)
        {
            _x = x;
            _y = y;
        }


        public BigRational X
        {
            get { return _x; }
        }

        public BigRational Y
        {
            get { return _y; }
        }
    }

    class Circle
    {
        private BigRationalPoint _center;
        private BigRational _radius;

        public Circle(BigRationalPoint center, BigRational radius)
        {
            _center = center;
            _radius = radius;
        }

        public BigRationalPoint Center
        {
            get { return _center; }
        }

        public BigRational Radius
        {
            get { return _radius; }
        }
    }
}