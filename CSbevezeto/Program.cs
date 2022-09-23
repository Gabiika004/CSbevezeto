namespace CSbevezto
{
    class Program
    {
        public static void Main(string[] args)
        {
            Feladat_1();
        }

        private static void Feladat_1()
        {
            Console.Write("Adja meg a medence átmérőjét (m): ");
            double atmero = Convert.ToDouble(Console.ReadLine());
            Console.Write("Adja meg a medence mélységét (m): ");
            double mely = Convert.ToDouble(Console.ReadLine());
            double sugar = atmero / 2;
            double alapTerulet = sugar * sugar * Math.PI;
            double terfogat = alapTerulet * mely;

            Console.WriteLine("A medencébe " + Math.Round(terfogat,2) + " köbméter víz fér.");
        }
    }
}


