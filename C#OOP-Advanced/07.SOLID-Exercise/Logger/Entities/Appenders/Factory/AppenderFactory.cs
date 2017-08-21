using System;
using System.Linq;
using System.Reflection;
using Logger.Interfaces;

namespace Logger.Entities.Appenders.Factory
{
    public class AppenderFactory
    {
        public IAppender CreateAppender(string appenderName, ILayout layout)
        {
            Type appenderType = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(t => t.Name == appenderName);
            return (IAppender)Activator.CreateInstance(appenderType, layout);
        }
    }
}