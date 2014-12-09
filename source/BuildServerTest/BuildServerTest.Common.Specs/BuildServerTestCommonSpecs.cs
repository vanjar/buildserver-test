using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Machine.Specifications;

namespace BuildServerTest.Common.Specs
{
    public class when_getting_data_from_common
    {
        private static CommonExecutor _commonExecutor;
        private static string _result;
        private Establish context = () =>
        {
            _commonExecutor = new CommonExecutor();
            _result = string.Empty;
        };

        private Because of = () =>
        {
            _result = _commonExecutor.GetHumanizedDateTimeAsync(-30).Result;
        };

        private It should_return_result = () =>
        {
            _result.ShouldNotBeNull();
            _result.ShouldNotBeEmpty();
        };

        private It should_contain_humanized_string = () => _result.ShouldContain("yesterday");
    }

}
