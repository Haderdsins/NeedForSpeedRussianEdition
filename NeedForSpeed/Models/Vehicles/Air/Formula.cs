namespace NeedForSpeed.Models.Vehicles.Air;

public static class Formula
{
    public static int CalculateTimeOfRace(double speed, double koefOfAcceleration, double distance)
    {
        // Используем квадратное уравнение движения
        double time = (-speed + Math.Sqrt(speed * speed + 2 * koefOfAcceleration * distance)) / koefOfAcceleration;
        
        // Убеждаемся, что время положительное (отрицательное время в данном контексте не имеет смысла)
        return (int)Math.Max(0, time);
    }
    public static int CalculateTimeOfRaceSimple(double speed, double koefOfAcceleration, double distance)
    {
        // Используем простую линейную зависимость между скоростью, ускорением и расстоянием
        double time = distance / (speed * (1 + koefOfAcceleration));

        // Убеждаемся, что время положительное
        return (int)Math.Max(0, time);
    }


    public static int CalculateTimeOfRaceSqrt(double speed, double koefOfAcceleration, double distance)
    {
        // Используем квадратичную функцию
        double time = Math.Sqrt(distance / speed + 1) / koefOfAcceleration;

        // Убеждаемся, что время положительное
        return (int)Math.Max(0, time);
    }

    public static int CalculateTimeOfRaceSquareRoot(double speed, double koefOfAcceleration, double distance)
    {
        // Используем функцию с корнем движения
        double time = Math.Sqrt(2 * distance / koefOfAcceleration);

        // Убеждаемся, что время положительное
        return (int)Math.Max(0, time);
    }

}