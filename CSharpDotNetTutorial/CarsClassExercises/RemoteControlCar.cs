namespace CSharpDotNetTutorial.CarsClassExercises;
public class RemoteControlCar
{
    public int speed;
    public int batteryDrain;
    public int battery;
    public int metersDriven;

    public RemoteControlCar(int speed, int batteryDrain)
    {
        this.speed = speed;
        this.batteryDrain = batteryDrain;
        this.battery = 100;
        this.metersDriven = 0;
    }

    public bool BatteryDrained()
    {
        return this.battery <= 0 || this.battery < this.batteryDrain ? true : false;
    }

    public int DistanceDriven() => this.metersDriven;

    public void Drive()
    {
        if (!BatteryDrained())
        {
            this.battery -= this.batteryDrain;
            this.metersDriven += this.speed;
        }
    }

    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50, 4);
    }
}
