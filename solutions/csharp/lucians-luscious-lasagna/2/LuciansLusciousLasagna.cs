class Lasagna
{
    public int ExpectedMinutesInOven()
    {
        return 40;
    }

    public int RemainingMinutesInOven(int timeInOven)
    {
        return ExpectedMinutesInOven() - timeInOven;
    }

    public int PreparationTimeInMinutes(int layers)
    {
        return 2 * layers;
    }

    public int ElapsedTimeInMinutes(int layers, int timeInOven)
    {
        return PreparationTimeInMinutes(layers) + timeInOven;
    }
}
