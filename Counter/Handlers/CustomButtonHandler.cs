namespace Counter.Handlers;

public partial class CustomButtonHandler
{
    public static void Handle()
    {
        CustomHandler();
    }

    static partial void CustomHandler();
}