using InterviewApp.Interfaces;

namespace InterviewApp.iOS.Services
{
    public class PlatformService : IPlatformService
    {
        // This could be any iOS specific code. While this specific code may be possible to do in a
        // cross-platform manner, treat it as if it is neccesary to be called from the iOS project.
        public string GetPlatformSpecificString() => UIKit.UIDevice.CurrentDevice.LocalizedModel;
    }
}
