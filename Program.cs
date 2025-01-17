using SafeLinks_Decoder;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        // Створюємо форму, але не показуємо її
        SafeLinksDecoder mainForm = new SafeLinksDecoder();

        // Запускаємо додаток без вказання форми
        Application.Run();
    }
}
