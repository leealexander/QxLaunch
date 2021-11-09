using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QxLaunch
{
    public static class Registry
    {
        public static IServiceProvider Initialise()
        {
            var serviceCollection = new ServiceCollection();

            return serviceCollection.BuildServiceProvider();
        }
    }
}
