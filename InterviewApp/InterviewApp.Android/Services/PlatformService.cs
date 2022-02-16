using InterviewApp.Interfaces;

namespace InterviewApp.Droid.Services
{
    public class PlatformService : IPlatformService
    {
        public string GetPlatformSpecificString() => $"{Android.OS.Build.Manufacturer} {Android.OS.Build.Model}";
    }
}
