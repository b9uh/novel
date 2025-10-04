namespace Expr11
{
    /* Expr11. Дано время в часах и минутах. Найти угол
     * от часовой к минутной стрелке на обычных часах. */
    internal class Program
    {
        // МЕТОД-РЕШЕНИЕ
        static double GetAngle(int timeInHours, int timeInMinutes)
        {
            timeInHours = timeInHours % 12;

            // угол часовой стрелки
            var angleForHours = timeInHours * 30 + timeInMinutes * 0.5;
            // угол минутной стрелки
            var angleForMinutes = timeInMinutes * 6;
            // угол между стрелками
            var angle = Math.Max(angleForHours, angleForMinutes) - Math.Min(angleForHours, angleForMinutes);

            // возвращаем минимальный угол между стрелками
            return Math.Min(360 - angle, angle);
        }

        // Запуск метода-решения для проверки работы
        static void Main(string[] args)
        {
            // ПРОСТЕЙШИЙ ТЕСТ на работосопособность
            var hours = 2;
            var minutes = 35;
            var angle = GetAngle(hours, minutes);
            Console.WriteLine($"Время = {hours}:{minutes}");
            Console.WriteLine($"Угол между часовой и минутной стрелками = {angle}");

            hours = 1;
            minutes = 55;
            angle = GetAngle(hours, minutes);
            Console.WriteLine($"Время = {hours}:{minutes}");
            Console.WriteLine($"Угол между часовой и минутной стрелками = {angle}");

            hours = 18;
            minutes = 12;
            angle = GetAngle(hours, minutes);
            Console.WriteLine($"Время = {hours}:{minutes}");
            Console.WriteLine($"Угол между часовой и минутной стрелками = {angle}");
        }
    }
}
