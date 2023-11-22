using System.Security.Cryptography;

namespace NeedForSpeed.Models.Abstracts;

public abstract class Vehicle
{
    public string Name { get; init; }
    protected int Speed { get; init;}

    public abstract int Go(int distance);
}