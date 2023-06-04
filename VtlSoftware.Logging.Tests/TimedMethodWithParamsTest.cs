using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VtlSoftware.Logging.Tests
{
    public class TimedMethodWithParamsTest
    {
        [TimedLogMethod]
        private string ChangeString(string stringToChange) { return stringToChange.ToUpper(); }
    }
}
