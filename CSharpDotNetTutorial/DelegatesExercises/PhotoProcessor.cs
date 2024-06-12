namespace CSharpDotNetTutorial.DelegatesExercises;
public class PhotoProcessor
{
    // Custom delegate example
    // public delegate void PhotoFilterHandler(Photo photo);
    // public void Process(string path, PhotoFilterHandler filterHandler)

    public void Process(string path, Action<Photo> filterHandler)
    {
        var photo = Photo.Load(path);

        filterHandler(photo);

        photo.Save();
    }
}
