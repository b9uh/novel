namespace Billiards;

public static class BilliardsTask
{
    /// <summary>
    /// Метод для расчета угла отскока шарика от стены
    /// </summary>
    /// <param name="directionRadians">Угол направления движения шара</param>
    /// <param name="wallInclinationRadians">Угол стены</param>
    /// <returns>Угол отскока</returns>
    public static double BounceWall(double directionRadians, double wallInclinationRadians)
    {
        return wallInclinationRadians * 2 - directionRadians;
    }
}