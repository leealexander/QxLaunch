using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace QxLaunch.AppExplorer
{
    public interface IAppDetails
    {
        public string Name { get; }

        public Task Launch(IEnumerable<string> args, CancellationToken cancellationToken);
    }
}
