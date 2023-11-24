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
}