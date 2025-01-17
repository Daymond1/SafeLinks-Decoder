using SafeLinks_Decoder;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        SafeLinksDecoder mainForm = new SafeLinksDecoder();

        Application.Run();
    }
}
