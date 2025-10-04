namespace Expr5
{
    /* Expr5. Найти количество високосных лет
     * на отрезке [a, b] не используя циклы. */
    internal class Program
    {
        // ВСПОМОГАТЕЛЬНЫЙ МЕТОД
        static int LeapYearCalc(int year)
        {
            // считаем кол-во високосных лет от 1 до year года
            return year / 4 - year / 100 + year / 400;
        }
        // МЕТОД-РЕШЕНИЕ
        static int LeapYearCalc(int year1, int year2)
        {
            // считаем кол-во високосных лет на отрезке путем вычитания
            // високосных лет меньшего года из високосных лет большего
            return LeapYearCalc(year2) - LeapYearCalc(year1);
        }

        // Запуск метода-решения для проверки работы
        static void Main(string[] args)
        {
            // ПРОСТЕЙШИЙ ТЕСТ на работосопособность
            var year1 = 111;
            var year2 = 1200;
            
            Console.WriteLine($"Отрезок = [{year1}, {year2}]");
            var leapYearCount= LeapYearCalc(year1, year2);
            Console.WriteLine($"Количество високосных лет = {leapYearCount}");

        }
    }
}
