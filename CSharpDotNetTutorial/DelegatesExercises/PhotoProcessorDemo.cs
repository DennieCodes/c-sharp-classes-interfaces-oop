namespace CSharpDotNetTutorial.DelegatesExercises;
static class PhotoProcessorDemo
{
    public static void Show()
    {
        var photoProcessor = new PhotoProcessor();
        var filters = new PhotoFilters();

        // Custom delegate example
        //PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness;

        Action<Photo> filterHandler = filters.ApplyBrightness;
        filterHandler += filters.ApplyContrast;
        filterHandler += RemoveRedEyeFilter;

        photoProcessor.Process("http://www.example.com", filterHandler);
    }

    static void RemoveRedEyeFilter(Photo photo)
    {
        Console.WriteLine("Apply RemoveRedEye");
    }
}
