using System;

[assembly:InterviewApp.Internal.LinkerSafe]
namespace InterviewApp.Internal
{

    [AttributeUsage(AttributeTargets.Assembly)]
    internal sealed class LinkerSafeAttribute : Attribute { }
}
