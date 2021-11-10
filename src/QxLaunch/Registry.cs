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
            var services = new ServiceCollection();


            services.Scan(scan =>
            {
                scan.FromCallingAssembly().AddClasses().AsMatchingInterface();
                scan.FromCallingAssembly().AddClasses();
            });


            return services.BuildServiceProvider();
        }
    }
}
