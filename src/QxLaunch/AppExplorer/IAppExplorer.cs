using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QxLaunch.AppExplorer
{
    public interface IAppExplorer
    {
        public IAsyncEnumerable<IAppDetails> GetAppsAsync();
    }
}
