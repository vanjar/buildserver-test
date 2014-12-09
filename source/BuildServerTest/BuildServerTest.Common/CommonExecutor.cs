using System;
using System.Threading;
using System.Threading.Tasks;
using Humanizer;

namespace BuildServerTest.Common
{
    public class CommonExecutor
    {
        public async Task<string> GetHumanizedDateTimeAsync(int hours)
        {
            return await Task.Factory.StartNew(() =>
            {
                Thread.Sleep(1000);
                return DateTime.Now.AddHours(hours).Humanize();
            });
        }
    }
}
