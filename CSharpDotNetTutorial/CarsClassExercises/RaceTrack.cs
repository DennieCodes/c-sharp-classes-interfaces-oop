namespace CSharpDotNetTutorial.CarsClassExercises;
public class RaceTrack
{
    private int distance;

    public RaceTrack(int distance)
    {
        this.distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        int driveCycle = car.battery / car.batteryDrain;

        return car.speed * driveCycle >= this.distance ? true : false;
    }
}
