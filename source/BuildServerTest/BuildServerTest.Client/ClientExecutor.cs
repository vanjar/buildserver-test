using System.Threading.Tasks;
using BuildServerTest.Common;
namespace BuildServerTest.Client
{
    public class ClientExecutor
    {
        readonly CommonExecutor _common;

        public ClientExecutor()
        {
            _common = new CommonExecutor();
        }

        public async Task<string> GetSampleDataAsync(string header)
        {
              return string.Format("{0} {1}",header, await _common.GetHumanizedDateTimeAsync(-30));
        }
    }
}
