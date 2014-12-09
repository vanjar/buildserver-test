using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Machine.Specifications;

namespace BuildServerTest.Client.Specs
{
    public class when_getting_data_from_client
    {
        private static ClientExecutor _clientExecutor;
        private static string _result;
        private Establish context = () =>
        {
            _clientExecutor = new ClientExecutor();
            _result = string.Empty;
        };

        private Because of = () =>
        {
            _result = _clientExecutor.GetSampleDataAsync("This is header.").Result;
        };

        private It should_return_result = () =>
        {
            _result.ShouldNotBeNull();
            _result.ShouldNotBeEmpty();
        };

        private It should_contain_header = () => _result.ShouldContain("This is header.");
    }

}
