namespace CSharpDotNetTutorial.CarClassExercise;
public class RemoteControlCar
{
    private int _distanceDriven = 0;
    private int _batteryPercentage = 100;

    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return $"Driven {this._distanceDriven} meters";
    }

    public string BatteryDisplay()
    {
        return this._batteryPercentage > 0 ?
            $"Battery at {this._batteryPercentage}%" :
            "Battery empty";
    }

    public void Drive()
    {
        if (this._batteryPercentage > 0)
        {
            this._distanceDriven += 20;
            this._batteryPercentage -= 1;
        }
    }
}
