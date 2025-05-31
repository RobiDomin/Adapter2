using static System.Net.Mime.MediaTypeNames;

namespace Adapter2
{
    public class Program
    {
        public static void Main()
        {
            NewLogger newLogger = new NewLogger();
            IOldLogger adaptedLogger = new LoggerAdapter(newLogger);

            Application app = new Application(adaptedLogger);
            app.Run();
        }
    }
}
