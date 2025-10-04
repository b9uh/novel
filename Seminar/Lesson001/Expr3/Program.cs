namespace Expr3
{
    /* Expr3. Задано время Н часов (ровно). Вычислить угол
     * в градусах между часовой и минутной стрелками.
     * Например, 5 часов -> 150 градусов, 20 часов
     * -> 120 градусов. Не использовать циклы. */
    internal class Program
    {
        // МЕТОД-РЕШЕНИЕ
        static int GetHourAngle(int hour)
        {
            // рассчитываем 2 угла (по часовой и против часовой) и берем минимальное значение
            return Math.Min(hour % 12 * 30, (12 - hour % 12) * 30);
        }

        // Запуск метода-решения для проверки работы
        static void Main(string[] args)
        {
            // ПРОСТЕЙШИЙ ТЕСТ на работосопособность
            var hour = 5;
            Console.WriteLine($"Время = {hour} часов");
            var angle = GetHourAngle(hour);
            Console.WriteLine($"Угол между часовой и минутной стрелками = {angle}");

            hour = 20;
            Console.WriteLine($"Время = {hour} часов");
            angle = GetHourAngle(hour);
            Console.WriteLine($"Угол между часовой и минутной стрелками = {angle}");

            hour = 18;
            Console.WriteLine($"Время = {hour} часов");
            angle = GetHourAngle(hour);
            Console.WriteLine($"Угол между часовой и минутной стрелками = {angle}");
        }
    }
}
