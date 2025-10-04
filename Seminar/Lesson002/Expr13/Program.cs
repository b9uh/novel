namespace Expr13
{
    /* Expr13. 1084. Пусти козла в огород 
     * Козла пустили в квадратный огород и привязали к колышку. 
     * Колышек воткнули точно в центре огорода. Козёл ест всё, 
     * до чего дотянется, не перелезая через забор огорода и не
     * разрывая веревку. Какая площадь огорода будет объедена?
     * Даны длина веревки и размеры огорода. */
    internal class Program
    {
        // МЕТОД-РЕШЕНИЕ
        static double GetEatenArea(int gardenSize, int ropeLength)
        {
            // половина длины стороны огорода
            double halfGardenSize = gardenSize / 2;
            double eatenArea = 0;

            // если радиус веревки меньше половины длины огорода,
            // то съеденная площадь равна площади круга
            if (ropeLength <= halfGardenSize)
            {
                eatenArea = Math.PI * ropeLength * ropeLength;
            }
            // если радиус веревки больше половины диагонали огорода,
            // то съеденная площадь равна площади квадрата
            else if (ropeLength >= (gardenSize * Math.Sqrt(2)) / 2)
            {
                eatenArea = gardenSize * gardenSize;
            }
            // если окружность частично выходит за рамки огорода,
            // то съеденная площадь равна площади круга - 4 площади сегмента круга
            else if (ropeLength > halfGardenSize)
            {
                var angleOfSegment = 2 * Math.Acos(halfGardenSize / ropeLength);
                var areaOfSegment = (ropeLength * ropeLength / 2) * (angleOfSegment - Math.Sin(angleOfSegment));
                eatenArea = Math.PI * ropeLength * ropeLength - 4 * areaOfSegment;
            }

            return Math.Round(eatenArea, 3);
        }

        // Запуск метода-решения для проверки работы
        static void Main(string[] args)
        {
            // ПРОСТЕЙШИЙ ТЕСТ на работосопособность
            var gardenSize = 10;
            var ropeLength = 6;
            var area = GetEatenArea(gardenSize, ropeLength);
            Console.WriteLine($"Длина стороны огорода = {gardenSize}, длина веревки = {ropeLength}");
            Console.WriteLine($"Съеденная площадь = {area}");
        }
    }
}
