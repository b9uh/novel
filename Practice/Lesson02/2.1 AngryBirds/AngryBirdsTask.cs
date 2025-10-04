using System;

namespace AngryBirds;

public static class AngryBirdsTask
{
    const double g = 9.8;
    public static double FindSightAngle(double velocity0, double distance)
    {
        // расчет угла по формуле α = 1/2 * arcsin(g*d/v0^2)
        return Math.Asin((g * distance) / (velocity0 * velocity0)) / 2; 
    }
}