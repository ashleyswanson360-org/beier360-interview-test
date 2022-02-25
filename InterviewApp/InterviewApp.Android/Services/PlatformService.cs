using InterviewApp.Interfaces;

namespace InterviewApp.Droid.Services
{
    public class PlatformService : IPlatformService
    {
        // This could be any Android specific code. While this specific code may be possible to do in a
        // cross-platform manner, treat it as if it is neccesary to be called from the Android project.
        public string GetPlatformSpecificString() => $"{Android.OS.Build.Manufacturer} {Android.OS.Build.Model}".ToUpper();
    }
}
