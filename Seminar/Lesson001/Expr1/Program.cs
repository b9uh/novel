namespace Expr1
{
    /* Expr1. Как поменять местами значения двух переменных?
     * Можно ли это сделать без ещё одной временной переменной.
     * Стоит ли так делать? */
    internal class Program
    {
        // МЕТОД-РЕШЕНИЕ
        static void SwapVariables(ref int x, ref int y)
        {   
            x = x + y;
            y = x - y;
            x = x - y;
        }

        // Запуск метода-решения для проверки работы
        static void Main(string[] args)
        {
            // ПРОСТЕЙШИЙ ТЕСТ на работосопособность
            var x = 18;
            var y = 3;

            Console.WriteLine($"Первое число = {x}, второе число = {y}");
            SwapVariables(ref x, ref y);
            Console.WriteLine($"Первое число = {x}, второе число = {y}");
        }
    }
}
