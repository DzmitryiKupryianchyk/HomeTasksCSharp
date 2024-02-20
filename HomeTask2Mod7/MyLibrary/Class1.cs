namespace MyLibrary
{
    public class Cone
    {
        private const double pi = (double)Math.PI;
        private double r;
        private double h;
        private double l2;
        private double l;
        private double surAr;
        private double totlAr;
        public Cone(double r, double h)
        {
            this.r = r;
            this.h = h;
        }
        public void SurfaceArea()
        {
            surAr = pi * Math.Pow(r, 2);
        }
        public void TotalArea()
        {
            l2 = Math.Pow(r, 2) + Math.Pow(h, 2);
            l = Math.Sqrt(l2);
            totlAr = pi * r * l + pi * r;

        }
        public void OutputInConsole()
        {
            Console.WriteLine($"Радиус конуса = {r}, высота = {h}");
            Console.WriteLine();
            Thread.Sleep(1000);
            Console.WriteLine($"Расчет площади поверхности основания конуса производится по формуле: S=πr²");
            Console.WriteLine($"Где π - математическая константа = {pi}, а r-радиус = {r}");
            Console.WriteLine($"{nameof(surAr)} = {pi} * {r}²");
            Console.WriteLine($"{nameof(surAr)} = {surAr}");
            Console.WriteLine();
            Thread.Sleep(1000);
            Console.WriteLine($"Для расчета полной площади конуса необходимо найти образующую");
            Console.WriteLine($"Согласно теореме пифагора l²= r² + h² где h - высота конуса = {h}");
            Console.WriteLine($"{nameof(l)}² = {Math.Pow(r, 2)} + {Math.Pow(h, 2)}");
            Console.WriteLine($"{nameof(l)} = {l}");
            Console.WriteLine();
            Thread.Sleep(1000);
            Console.WriteLine($"Расчет полной площади поверхности конуса производится по формуле: Sкон = πrl + πr");
            Console.WriteLine($"{nameof(totlAr)} = {pi} * {r} * {l} + {pi} * {r}");
            Console.WriteLine($"{nameof(totlAr)} = {totlAr}");

        }
    }
}
