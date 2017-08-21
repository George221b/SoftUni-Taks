using Logger.Core;
using Logger.Core.IO;
using Logger.Entities.Appenders.Factory;
using Logger.Entities.Layouts.Factory;
using Logger.Interfaces;

namespace Logger
{
    public class Startup
    {
        public static void Main()
        {
            IReader reader = new Reader();
            IWriter writer = new Writer();

            LayoutFactory layoutFactory = new LayoutFactory();
            AppenderFactory appenderFactory = new AppenderFactory();

            Controller controller = new Controller(layoutFactory, appenderFactory);
            Engine engine = new Engine(reader, writer, controller);

            engine.Run();
        }
    }
}
