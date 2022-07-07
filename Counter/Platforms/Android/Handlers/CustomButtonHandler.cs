using Microsoft.Maui.Platform;

namespace Counter.Handlers;

public partial class CustomButtonHandler
{
    static partial void CustomHandler()
    {
        Microsoft.Maui.Handlers.ButtonHandler.Mapper.AppendToMapping("MyCustomization", (handler, view) =>
        {
            handler.PlatformView.SetBackgroundColor(Colors.Blue.ToPlatform());
        });
    }
}