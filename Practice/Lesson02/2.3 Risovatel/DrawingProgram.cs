using System;
using Avalonia.Media;
using RefactorMe.Common;

namespace RefactorMe
{
    class Drawer
    {
        static float x, y;
        static IGraphics graphics;

        public static void Initialize(IGraphics newGraphics)
        {
            graphics = newGraphics;
            graphics.Clear(Colors.Black);
        }

        /// <summary>
        /// Устанавливает позицию рисователя по координатам
        /// </summary>
        /// <param name="x0">Новая координата x</param>
        /// <param name="y0">Новая координата y</param>
        public static void SetPosition(float x0, float y0)
        {
            x = x0; y = y0;
        }

        /// <summary>
        /// Делает шаг длиной length в направлении angle и рисует пройденную траекторию
        /// </summary>
        /// <param name="pen">Pen</param>
        /// <param name="length">Длина шага</param>
        /// <param name="angle">Угол шага</param>
        public static void Step(Pen pen, double length, double angle)
        {
            var x1 = (float)(x + length * Math.Cos(angle));
            var y1 = (float)(y + length * Math.Sin(angle));
            graphics.DrawLine(pen, x, y, x1, y1);
            x = x1; y = y1;
        }

        /// <summary>
        /// Меняет позицию рисователя на расстояние distance под углом angle
        /// </summary>
        /// <param name="distance">Расстояние</param>
        /// <param name="angle">Угол</param>
        public static void ChangePosition(double distance, double angle)
        {
            x = (float)(x + distance * Math.Cos(angle)); 
            y = (float)(y + distance * Math.Sin(angle));
        }
    }
    
    public class ImpossibleSquare
    {
        // коэффиценты размера
        // 0.375 / 0.04 == 9.375 (соотношение длинных и коротких линий)
        static float sizeRatio = 0.375f;
        static float sizeRatio2 = sizeRatio / 9.375f;
        
        static double squareRootOfTwo = Math.Sqrt(2);
        static Pen penColor = new Pen(Brushes.Yellow);
        
        /// <summary>
        /// Рисует сторону квадрата
        /// </summary>
        /// <param name="pen">Pen</param>
        /// <param name="size">Размер стороны</param>
        /// <param name="angle">Угол рисования</param>
        public static void DrawSquareSide(Pen pen, double size, double size2, double angle)
        {      
            Drawer.Step(pen, size, angle);
            Drawer.Step(pen, size2 * squareRootOfTwo, angle + Math.PI / 4);
            Drawer.Step(pen, size, angle + Math.PI);
            Drawer.Step(pen, size - size2, angle + Math.PI / 2);
            Drawer.ChangePosition(size2 * 2, angle - Math.PI);
            Drawer.ChangePosition(size2, angle + Math.PI / 2);
        }

        /// <summary>
        /// Рисует невозможный квадрат
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="turningAngle"></param>
        /// <param name="graphics"></param>
        public static void DrawSquare(int width, int height, double turningAngle, IGraphics graphics)
        {
            // turningAngle пока не используется, но будет использоваться в будущем
            Drawer.Initialize(graphics);

            var size = Math.Min(width, height);
            var finalSize = size * sizeRatio;
            var finalSize2 = size * sizeRatio2;
            var diagonalLength = squareRootOfTwo * (size * sizeRatio + size * sizeRatio2) / 2;
            var x0 = (float)(diagonalLength * Math.Cos(Math.PI / 4 + Math.PI)) + width / 2f;
            var y0 = (float)(diagonalLength * Math.Sin(Math.PI / 4 + Math.PI)) + height / 2f;

            Drawer.SetPosition(x0, y0);
            //Рисуем 1-ую сторону
            DrawSquareSide(penColor, finalSize, finalSize2, 0);
            // Рисуем 2-ую сторону
            DrawSquareSide(penColor, finalSize, finalSize2, -Math.PI / 2);
            //Рисуем 3-ю сторону
            DrawSquareSide(penColor, finalSize, finalSize2, Math.PI);
            //Рисуем 4-ую сторону
            DrawSquareSide(penColor, finalSize, finalSize2, Math.PI / 2);

            // ИСПРАВИТЬ ДУБЛИРОВАНИЕ КОДА
        }
    }
}