class RemoteControlCar
{
    private int distanceDriven;
    private int batteryPercentage;

    public RemoteControlCar()
    {
        distanceDriven = 0; batteryPercentage = 100;
    }
    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return $"Driven {distanceDriven} meters";
    }

    public string BatteryDisplay()
    {
        if (batteryPercentage == 0) return $"Battery empty";
        return $"Battery at {batteryPercentage}%";
    }

    public void Drive()
    {
        if (batteryPercentage == 0) return;
        distanceDriven += 20;
        batteryPercentage -= 1;


    }
}
