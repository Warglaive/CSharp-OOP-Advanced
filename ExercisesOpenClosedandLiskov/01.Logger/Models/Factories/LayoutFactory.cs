using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Logger.Models.Contracts;

namespace Logger.Models.Factories
{
    public class LayoutFactory
    {
        public ILayout CreateLayout(string layoutTypeString)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();

            IEnumerable<Type> layoutClasses = assembly.GetTypes()
                .Where(t => typeof(ILayout).IsAssignableFrom(t));

            Type layoutType = layoutClasses.FirstOrDefault(t => t.Name == layoutTypeString);


            //ILayout layout = null;
            if (layoutType == null)
            {
                throw new ArgumentException("Invalid Layout Type!");
            }
            ConstructorInfo constructor = layoutType.GetConstructors()[0];
            ILayout layout = (ILayout)constructor.Invoke(null);
            return layout;
        }
    }
}