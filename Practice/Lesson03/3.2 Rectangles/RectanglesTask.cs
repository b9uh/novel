using System;

namespace Rectangles;

public static class RectanglesTask
{
    // Пересекаются ли два прямоугольника (пересечение только по границе также считается пересечением)
    public static bool AreIntersected(Rectangle r1, Rectangle r2)
    {
        // так можно обратиться к координатам левого верхнего угла первого прямоугольника: r1.Left, r1.Top
        if (r1.Left <= r2.Left && r1.Top <= r2.Top)
        return false;
    }

    // Площадь пересечения прямоугольников
    public static int IntersectionSquare(Rectangle r1, Rectangle r2)
    {
        if (r1.Right >= r2.Left)
        {
            if (r1.Bottom >= r2.Top)
            {
                return (r1.Right - r2.Left) * (r1.Bottom - r2.Top);
            }
            else
            {
                return (r1.Right - r2.Left) * (r2.Bottom - r1.Top);
            }
        }

        return 0;
    }

    // Если один из прямоугольников целиком находится внутри другого — вернуть номер (с нуля) внутреннего.
    // Иначе вернуть -1
    // Если прямоугольники совпадают, можно вернуть номер любого из них.
    public static int IndexOfInnerRectangle(Rectangle r1, Rectangle r2)
    {
        return -1;
    }
}