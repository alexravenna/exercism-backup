class Lasagna
{
    public static int ExpectedMinutesInOven()
    {
        return 40;
    }

    public int RemainingMinutesInOven(int timeInOven)
    {
        return Lasagna.ExpectedMinutesInOven - timeInOven;
    }

    public static int PreparationTimeInMinutes(int layers)
    {
        return 2 * layers;
    }

    public static int ElapsedTimeInMinutes(int layers, int timeInOven)
    {
        return PreparationTimeInMinutes(layers) + timeInOven;
    }
}
