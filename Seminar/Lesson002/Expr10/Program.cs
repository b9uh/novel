namespace Expr10
{
    /* Expr10. Найти сумму всех положительных
     * чисел меньше 1000 кратных 3 или 5. */
    internal class Program
    {
        // ВСПОМОГАТЕЛЬНЫЙ МЕТОД для рассчета арифметической прогрессии
        static int GetSumOfMultiple(int borderNumber, int divisor)
        {
            // кол-во членов арифметической прогрессии 
            var countDivisibles = borderNumber / divisor;
            // сумма арифметической прогрессии
            var sumOfMultiples = (2 * divisor + divisor * (countDivisibles - 1)) * countDivisibles / 2;

            return sumOfMultiples;
        }

        // МЕТОД-РЕШЕНИЕ
        // работает только для простых делителей
        static int GetSumOfMultiple(int borderNumber, int divisor1, int divisor2)
        {
            // необходимы числа меньше чем borderNumber
            borderNumber -= 1;

            // произведение первого и второго делителя
            var divisor12 = divisor1 * divisor2;

            // суммы арифметических прогрессий для 
            // первого делителя/второго делителя/произведения первого и второго делителя
            var sumOfMultiples1 = GetSumOfMultiple(borderNumber, divisor1);
            var sumOfMultiples2 = GetSumOfMultiple(borderNumber, divisor2);
            var sumOfMultiples12 = GetSumOfMultiple(borderNumber, divisor12);

            return sumOfMultiples1 + sumOfMultiples2 - sumOfMultiples12;
        }

        // Запуск метода-решения для проверки работы
        static void Main(string[] args)
        {
            // ПРОСТЕЙШИЙ ТЕСТ на работосопособность
            var number = 1000;
            var divisor1 = 3;
            var divisor2 = 5;

            var sum = GetSumOfMultiple(number, divisor1, divisor2);
            Console.WriteLine($"Сумма чисел, кратных {divisor1} или {divisor2} и меньших {number}: {sum}");
        }
    }
}
