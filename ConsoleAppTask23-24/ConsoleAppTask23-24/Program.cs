namespace ConsoleAppTask22._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine("===часть 1 цилиндр===");
            program.PartOneTwo();
            Console.WriteLine("===часть 2 прямая треугольная призма===");
            program.PartThree();
            Console.WriteLine("===часть 3 прямая призма с четырехугольным основанием ===");
            program.PartFour();
        }

        public void PartOneTwo()
        {
            Cylinder cylinder = new Cylinder();
            Console.WriteLine("Введите координаты первой точки (X,Y)");

            cylinder.PointOne.X = double.Parse(Console.ReadLine()!);
            cylinder.PointOne.Y = double.Parse(Console.ReadLine()!);
            Console.WriteLine("Введите координаты второй точки (X,Y)");

            cylinder.PointTwo.X = double.Parse(Console.ReadLine()!);
            cylinder.PointTwo.Y = double.Parse(Console.ReadLine()!);

            Console.WriteLine("Введите высоту цилиндра");
            cylinder.Height = double.Parse(Console.ReadLine()!);

            Console.WriteLine($"площадь основания: {cylinder.GetFootSquare()}");
            Console.WriteLine($"длина окружности в основании: {cylinder.GetFootPerimeter()}");
            Console.WriteLine($"объем цилиндра: {cylinder.GetVolume()}");
            Console.WriteLine($"площадь боковой поверхности: {cylinder.GetVolumeSideSurface()}");
        }

        public void PartThree()
        {
            StraightTriangularPrism straightTriangularPrism = new StraightTriangularPrism();
            Console.WriteLine("Введите координаты первой точки (X,Y)");

            straightTriangularPrism.PointOne.X = double.Parse(Console.ReadLine()!);
            straightTriangularPrism.PointOne.Y = double.Parse(Console.ReadLine()!);
            Console.WriteLine("Введите координаты второй точки (X,Y)");

            straightTriangularPrism.PointTwo.X = double.Parse(Console.ReadLine()!);
            straightTriangularPrism.PointTwo.Y = double.Parse(Console.ReadLine()!);
            Console.WriteLine("Введите координаты третьей точки (X,Y)");

            straightTriangularPrism.PointThree.X = double.Parse(Console.ReadLine()!);
            straightTriangularPrism.PointThree.Y = double.Parse(Console.ReadLine()!);

            Console.WriteLine("Введите высоту призмы");
            straightTriangularPrism.Height = double.Parse(Console.ReadLine()!);

            Console.WriteLine($"площадь основания: {straightTriangularPrism.GetFootSquare()}");
            Console.WriteLine($"периметр основания: {straightTriangularPrism.GetFootPerimeter()}");
            Console.WriteLine($"объем призмы: {straightTriangularPrism.GetVolume()}");
            Console.WriteLine($"площадь боковой поверхности: {straightTriangularPrism.GetVolumeSideSurface()}");
        }

        public void PartFour()
        {
            StraightPrismWithQuadrangularBase straightPrismWithQuadrangularBase = new StraightPrismWithQuadrangularBase();
            Console.WriteLine("Введите координаты первой точки (X,Y)");

            straightPrismWithQuadrangularBase.PointOne.X = double.Parse(Console.ReadLine()!);
            straightPrismWithQuadrangularBase.PointOne.Y = double.Parse(Console.ReadLine()!);
            Console.WriteLine("Введите координаты второй точки (X,Y)");

            straightPrismWithQuadrangularBase.PointTwo.X = double.Parse(Console.ReadLine()!);
            straightPrismWithQuadrangularBase.PointTwo.Y = double.Parse(Console.ReadLine()!);
            Console.WriteLine("Введите координаты третьей точки (X,Y)");
            straightPrismWithQuadrangularBase.PointThree.X = double.Parse(Console.ReadLine()!);
            straightPrismWithQuadrangularBase.PointThree.Y = double.Parse(Console.ReadLine()!);

            Console.WriteLine("Введите координаты четвертой точки (X,Y)");

            straightPrismWithQuadrangularBase.PointFour.X = double.Parse(Console.ReadLine()!);
            straightPrismWithQuadrangularBase.PointFour.Y = double.Parse(Console.ReadLine()!);

            Console.WriteLine("Введите высоту призмы");
            straightPrismWithQuadrangularBase.Height = double.Parse(Console.ReadLine()!);

            Console.WriteLine($"Призма является кубом? {straightPrismWithQuadrangularBase.IsCube()}");
            Console.WriteLine($"Призма является параллелепипедом? {straightPrismWithQuadrangularBase.IsParallelepiped()}");
            Console.WriteLine($"Призма является прямоугольным параллелепипедом? {straightPrismWithQuadrangularBase.IsRectangularParallelepiped()}");
            Console.WriteLine($"площадь основания: {straightPrismWithQuadrangularBase.GetFootSquare()}");
            Console.WriteLine($"периметр основания: {straightPrismWithQuadrangularBase.GetFootPerimeter()}");
            Console.WriteLine($"объем призмы: {straightPrismWithQuadrangularBase.GetVolume()}");
            Console.WriteLine($"площадь боковой поверхности: {straightPrismWithQuadrangularBase.GetVolumeSideSurface()}");
        }
    }
}