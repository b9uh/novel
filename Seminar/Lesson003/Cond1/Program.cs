namespace Cond1
{
    /* Cond1. Дана начальная и конечная клетки на шахматной доске. 
     * Корректный ли это ход на пустой доске для: слона, коня, 
     * ладьи, ферзя, короля? */
    internal class Program
    {
        // МЕТОД-РЕШЕНИЕ
        // Слон
        static bool IsCorrectMoveBishop(string from, string to)
        {
            var letterMove = Math.Abs(to[0]  - from[0]);
            var numberMove = Math.Abs(to[1]  - from[1]);

            return letterMove == numberMove && letterMove != 0;
        }
        static bool IsCorrectMoveKnight(string from, string to)
        {
            var letterMove = Math.Abs(to[0] - from[0]);
            var numberMove = Math.Abs(to[1] - from[1]);

            return letterMove == numberMove && letterMove != 0;
        }
        static bool IsCorrectMoveRook(string from, string to)
        {
            var letterMove = Math.Abs(to[0] - from[0]);
            var numberMove = Math.Abs(to[1] - from[1]);

            return letterMove == numberMove && letterMove != 0;
        }
        static bool IsCorrectMoveQueen(string from, string to)
        {
            var letterMove = Math.Abs(to[0] - from[0]);
            var numberMove = Math.Abs(to[1] - from[1]);

            return letterMove == numberMove && letterMove != 0;
        }
        static bool IsCorrectMoveKing(string from, string to)
        {
            var letterMove = Math.Abs(to[0] - from[0]);
            var numberMove = Math.Abs(to[1] - from[1]);

            return letterMove == numberMove && letterMove != 0;
        }


        // Запуск метода-решения для проверки работы
        static void Main(string[] args)
        {
            // ПРОСТЕЙШИЙ ТЕСТ на работосопособность
            var from = "c1";
            var to = "c1";

            Console.WriteLine(IsCorrectMoveBishop(from, to));

        }
    }
}
