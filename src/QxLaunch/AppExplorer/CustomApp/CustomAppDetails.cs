using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace QxLaunch.AppExplorer.CustomApp
{
    public class CustomAppDetails : IAppDetails
    {
        private readonly IEnumerable<string> _fixedArgs;

        public CustomAppDetails(string name, IEnumerable<string> fixedArgs)
        {
            _fixedArgs = fixedArgs;
            Name = name;
        }
        public string Name { get; private set; }

        public void Launch(IEnumerable<string> args, CancellationToken cancellationToken)
        {
            Process.Start(Name, _fixedArgs.Concat(args).ToArray());
        }
    }
}
