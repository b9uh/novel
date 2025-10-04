namespace Expr3
{
    /* Expr2. Задается натуральное трехзначное число
     * (гарантируется, что трехзначное). Развернуть его,
     * т.е. получить трехзначное число, записанное теми
     * же цифрами в обратном порядке. */
    internal class Program
    {
        // МЕТОД-РЕШЕНИЕ
        static void ReverseNumber(ref int number)
        {
            // сумма первой цифры, второй умноженной на 10 и последней умноженной на 100 
            number = number / 100 + number % 100 / 10 * 10 + number % 10 * 100;
        }

        // Запуск метода-решения для проверки работы
        static void Main(string[] args)
        {
            // ПРОСТЕЙШИЙ ТЕСТ на работосопособность
            var number = 576;
            Console.WriteLine($"Число = {number}");

            ReverseNumber(ref number);
            Console.WriteLine($"Развернутое число = {number}");
        }
    }
}
