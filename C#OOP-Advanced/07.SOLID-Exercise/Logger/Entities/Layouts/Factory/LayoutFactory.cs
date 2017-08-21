using System;
using System.Linq;
using System.Reflection;
using Logger.Interfaces;

namespace Logger.Entities.Layouts.Factory
{
    public class LayoutFactory
    {
        public ILayout CreateLayout(string layoutName)
        {
            Type layoutType = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(t => t.Name == layoutName);
            return (ILayout)Activator.CreateInstance(layoutType);
        }
    }
}
